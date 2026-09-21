# Environment-only image: SDK + restored NuGet packages, no test source.
# The test Job mounts the actual repo source fresh at run time (via an
# initContainer git clone into a shared PVC) rather than baking it in here,
# so code changes never require rebuilding this image - only a Dockerfile
# or .csproj change does. Mirrors atp.ApiAutomation.Portfolio's Dockerfile.
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY atp.ApiAutomation.Sharding.csproj ./
RUN dotnet restore atp.ApiAutomation.Sharding.csproj

# ShardPlanner (Phase 3) is prebuilt to a fixed path outside /app, since
# /app gets overwritten by whatever the test Job mounts there at run time.
# Sharded runs invoke it via `dotnet /opt/shardplanner/ShardPlanner.dll`.
WORKDIR /shardplanner-src
COPY Tools/ShardPlanner/ShardPlanner.csproj ./
RUN dotnet restore ShardPlanner.csproj
COPY Tools/ShardPlanner/Program.cs ./
RUN dotnet publish ShardPlanner.csproj -c Release -o /opt/shardplanner --no-restore

WORKDIR /app
ENTRYPOINT ["dotnet", "test"]
