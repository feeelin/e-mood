#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["e-mood-asp-net-core/e-mood-asp-net-core.csproj", "e-mood-asp-net-core/"]
RUN dotnet restore "./e-mood-asp-net-core/e-mood-asp-net-core.csproj"
COPY . .
WORKDIR "/src/e-mood-asp-net-core"
RUN dotnet build "./e-mood-asp-net-core.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./e-mood-asp-net-core.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "e-mood-asp-net-core.dll"]