FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./DemoJwt/DemoJwt.csproj", "DemoJwt/"]
COPY ["./Domain/Domain.csproj", "Domain/"]
COPY ["./Infra.Data/Infra.Data.csproj", "Infra.Data/"]
RUN dotnet restore "DemoJwt/DemoJwt.csproj"
COPY . .
WORKDIR "/src/DemoJwt"
RUN dotnet build "DemoJwt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoJwt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m mdmago
USER mdmago

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet DemoJwt.dll