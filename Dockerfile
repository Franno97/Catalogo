#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["src/Mre.Visas.Catalogo.Api/Mre.Visas.Catalogo.Api.csproj", "./Mre.Visas.Catalogo.Api/"]
COPY ["src/Mre.Visas.Catalogo.Application/Mre.Visas.Catalogo.Application.csproj", "./Mre.Visas.Catalogo.Application/"]
COPY ["src/Mre.Visas.Catalogo.Domain/Mre.Visas.Catalogo.Domain.csproj", "./Mre.Visas.Catalogo.Domain/"]
COPY ["src/Mre.Visas.Catalogo.Infrastructure/Mre.Visas.Catalogo.Infrastructure.csproj", "./Mre.Visas.Catalogo.Infrastructure/"]
RUN dotnet restore "Mre.Visas.Catalogo.Api/Mre.Visas.Catalogo.Api.csproj"

COPY ["src/Mre.Visas.Catalogo.Api", "./Mre.Visas.Catalogo.Api/"]
COPY ["src/Mre.Visas.Catalogo.Application", "./Mre.Visas.Catalogo.Application/"]
COPY ["src/Mre.Visas.Catalogo.Domain", "./Mre.Visas.Catalogo.Domain/"]
COPY ["src/Mre.Visas.Catalogo.Infrastructure", "./Mre.Visas.Catalogo.Infrastructure/"]
RUN dotnet build "Mre.Visas.Catalogo.Api/Mre.Visas.Catalogo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mre.Visas.Catalogo.Api/Mre.Visas.Catalogo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mre.Visas.Catalogo.Api.dll"]