FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/DemoJwt/DemoJwt.csproj", "src/DemoJwt/"]
COPY ["src/Domain/Domain.csproj", "src/Domain/"]
COPY ["src/Infra.Data/Infra.Data.csproj", "src/Infra.Data/"]
RUN dotnet restore "src/DemoJwt/DemoJwt.csproj"
COPY . .
WORKDIR "/src/src/DemoJwt"
RUN dotnet build "DemoJwt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoJwt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m md
USER md

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet DemoJwt.dll