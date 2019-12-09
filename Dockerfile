FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY src/Echo.Api/*.csproj ./src/Echo.Api/
COPY test/Echo.Api.Test/*.csproj ./test/Echo.Api.Test/
COPY Echo.sln ./

RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Echo.Api.dll"]