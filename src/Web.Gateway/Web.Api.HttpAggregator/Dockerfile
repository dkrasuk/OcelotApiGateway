FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Web.Gateway/Web.Api.HttpAggregator/Web.Api.HttpAggregator.csproj", "src/Web.Gateway/Web.Api.HttpAggregator/"]
RUN dotnet restore "src/Web.Gateway/Web.Api.HttpAggregator/Web.Api.HttpAggregator.csproj"
COPY . .
WORKDIR "/src/src/Web.Gateway/Web.Api.HttpAggregator"
RUN dotnet build "Web.Api.HttpAggregator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web.Api.HttpAggregator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web.Api.HttpAggregator.dll"]