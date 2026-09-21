# Environment-only image: SDK + restored NuGet packages, no test source.
# The test Job mounts the actual repo source fresh at run time (via an
# initContainer git clone into a shared PVC) rather than baking it in here,
# so code changes never require rebuilding this image - only a Dockerfile
# or .csproj change does. Mirrors atp.ApiAutomation.Portfolio's Dockerfile.
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY atp.ApiAutomation.Sharding.csproj ./
RUN dotnet restore atp.ApiAutomation.Sharding.csproj

ENTRYPOINT ["dotnet", "test"]
