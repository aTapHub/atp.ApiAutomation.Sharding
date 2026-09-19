#Requires -Version 7.0
# Generates the 50 fixture classes (500 tests total) and test-durations.json
# for the sharding proof-of-concept. Deterministic given -Seed: regenerating
# with the same seed produces byte-identical output, since mocked-single and
# mocked-sharded pipeline runs must execute the exact same set of tests to be
# a fair comparison.
[CmdletBinding()]
param(
    [int]$Seed = 42,
    [string]$OutputDir = (Join-Path $PSScriptRoot 'Tests'),
    [string]$ManifestPath = (Join-Path $PSScriptRoot 'test-durations.json')
)

$ErrorActionPreference = 'Stop'
$random = [System.Random]::new($Seed)

function New-DurationBucket([int]$Count, [int]$MinMs, [int]$MaxMs) {
    1..$Count | ForEach-Object { $random.Next($MinMs, $MaxMs + 1) }
}

# <5s: 50% (250), 5-10s: 30% (150), 15s: 10% (50), 20s: 5% (25), 30s: 5% (25)
$durations = [System.Collections.Generic.List[int]]::new()
$durations.AddRange([int[]](New-DurationBucket -Count 250 -MinMs 1000 -MaxMs 4999))
$durations.AddRange([int[]](New-DurationBucket -Count 150 -MinMs 5000 -MaxMs 9999))
$durations.AddRange([int[]](1..50 | ForEach-Object { 15000 }))
$durations.AddRange([int[]](1..25 | ForEach-Object { 20000 }))
$durations.AddRange([int[]](1..25 | ForEach-Object { 30000 }))

if ($durations.Count -ne 500) { throw "Expected 500 durations, got $($durations.Count)" }

# Fisher-Yates shuffle so classes end up with a realistic mix, not clusters
# of same-bucket tests.
for ($i = $durations.Count - 1; $i -gt 0; $i--) {
    $j = $random.Next(0, $i + 1)
    $tmp = $durations[$i]; $durations[$i] = $durations[$j]; $durations[$j] = $tmp
}

New-Item -ItemType Directory -Force -Path $OutputDir | Out-Null
Get-ChildItem -Path $OutputDir -Filter 'ShardClass*.cs' -ErrorAction SilentlyContinue | Remove-Item -Force

$manifest = [ordered]@{}
$classCount = 50
$testsPerClass = 10

for ($classIndex = 0; $classIndex -lt $classCount; $classIndex++) {
    $className = "ShardClass{0:D2}" -f ($classIndex + 1)
    $start = $classIndex * $testsPerClass

    $testMethods = for ($t = 0; $t -lt $testsPerClass; $t++) {
        $ms = $durations[$start + $t]
        # Index prefix guarantees a unique method name even if two tests in
        # the same class happen to roll the same duration.
        $testName = "Test{0:D2}_Sleeps_{1}ms" -f ($t + 1), $ms
        $manifest["$className.$testName"] = $ms

        @"
        [Test]
        public void $testName()
        {
            SleepService.Sleep($ms);
            Test.Pass(`"Slept ${ms}ms.`");
        }
"@
    }

    $classContent = @"
namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class $className : BaseTest
    {
$($testMethods -join "`n`n")
    }
}
"@

    Set-Content -LiteralPath (Join-Path $OutputDir "$className.cs") -Value $classContent -Encoding utf8NoBOM
}

$manifest | ConvertTo-Json | Set-Content -LiteralPath $ManifestPath -Encoding utf8NoBOM
Write-Output "Generated $classCount classes ($($classCount * $testsPerClass) tests) into $OutputDir"
Write-Output "Manifest written to $ManifestPath"
