FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY PaineldeAvaliador/PaineldeAvaliador.csproj PaineldeAvaliador/
RUN dotnet restore PaineldeAvaliador/PaineldeAvaliador.csproj
COPY . .
WORKDIR /src/PaineldeAvaliador
RUN dotnet build PaineldeAvaliador.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PaineldeAvaliador.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PaineldeAvaliador.dll"]
