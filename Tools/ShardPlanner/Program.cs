using System.Text.Json;

// Reads test-durations.json and partitions all tests into N shards via
// greedy bin-packing: sort tests by duration descending, repeatedly assign
// each to whichever shard currently has the lowest accumulated total.
// Balances by actual expected runtime, not test count.
//
// Two modes:
//   --shards N               Print a per-shard balance summary (verification).
//   --shards N --index I     Print only the NUnit --filter expression for
//                             shard I's tests, for a pod to consume directly.
const string TestNamespace = "atp.ApiAutomation.Sharding.Tests";

var options = ParseArgs(args);

var manifestJson = File.ReadAllText(options.ManifestPath);
var durations = JsonSerializer.Deserialize<Dictionary<string, int>>(manifestJson)
    ?? throw new InvalidOperationException($"Could not parse manifest at {options.ManifestPath}");

if (options.Shards < 1)
{
    throw new ArgumentException("--shards must be at least 1");
}

var shards = PlanShards(durations, options.Shards);

if (options.Index is int index)
{
    if (index < 0 || index >= options.Shards)
    {
        throw new ArgumentException($"--index must be between 0 and {options.Shards - 1}");
    }

    Console.WriteLine(BuildFilter(shards[index]));
}
else
{
    PrintSummary(shards);
}

static List<List<(string Name, int DurationMs)>> PlanShards(Dictionary<string, int> durations, int shardCount)
{
    var shards = new List<List<(string Name, int DurationMs)>>(shardCount);
    var totals = new long[shardCount];
    for (var i = 0; i < shardCount; i++)
    {
        shards.Add(new List<(string, int)>());
    }

    foreach (var test in durations.OrderByDescending(t => t.Value))
    {
        var lightest = Array.IndexOf(totals, totals.Min());
        shards[lightest].Add((test.Key, test.Value));
        totals[lightest] += test.Value;
    }

    return shards;
}

static string BuildFilter(List<(string Name, int DurationMs)> shard)
{
    return string.Join("|", shard.Select(t => $"FullyQualifiedName={TestNamespace}.{t.Name}"));
}

static void PrintSummary(List<List<(string Name, int DurationMs)>> shards)
{
    var totals = shards.Select(s => s.Sum(t => (long)t.DurationMs)).ToList();

    Console.WriteLine($"{"Shard",-8}{"Tests",-8}{"Total (ms)",-14}{"Total (s)",-10}");
    for (var i = 0; i < shards.Count; i++)
    {
        Console.WriteLine($"{i,-8}{shards[i].Count,-8}{totals[i],-14}{totals[i] / 1000.0,-10:F1}");
    }

    var min = totals.Min();
    var max = totals.Max();
    var spreadPct = max == 0 ? 0 : (max - min) * 100.0 / max;
    Console.WriteLine();
    Console.WriteLine($"Min: {min / 1000.0:F1}s  Max: {max / 1000.0:F1}s  Spread: {spreadPct:F1}%");
}

static (int Shards, int? Index, string ManifestPath) ParseArgs(string[] args)
{
    int? shards = null;
    int? index = null;
    var manifestPath = "test-durations.json";

    for (var i = 0; i < args.Length; i++)
    {
        switch (args[i])
        {
            case "--shards":
                shards = int.Parse(args[++i]);
                break;
            case "--index":
                index = int.Parse(args[++i]);
                break;
            case "--manifest":
                manifestPath = args[++i];
                break;
            default:
                throw new ArgumentException($"Unknown argument: {args[i]}");
        }
    }

    if (shards is null)
    {
        throw new ArgumentException("--shards <N> is required");
    }

    return (shards.Value, index, manifestPath);
}
