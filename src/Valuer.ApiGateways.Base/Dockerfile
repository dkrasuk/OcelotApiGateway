FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src


COPY ["src/Valuer.ApiGateways.Base/Valuer.ApiGateways.Base.csproj", "src/Valuer.ApiGateways.Base/"]

RUN dotnet restore "src/Valuer.ApiGateways.Base/Valuer.ApiGateways.Base.csproj"

COPY src/Valuer.ApiGateways.Base/*.csproj /src/src/Valuer.ApiGateways.Base/
#COPY src/Web.Gateway/Web.Api.HttpAggregator/*.csproj /src/src/Web.Gateway/Web.Api.HttpAggregator/
COPY src/Web.Gateway/ app/

COPY . .
WORKDIR "/src/src/Valuer.ApiGateways.Base"
RUN dotnet build "Valuer.ApiGateways.Base.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Valuer.ApiGateways.Base.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Valuer.ApiGateways.Base.dll"]