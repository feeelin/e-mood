FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
RUN apk update
RUN apk add sqlite
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["e-mood-dotnet/e-mood-dotnet.csproj", "e-mood-dotnet/"]
RUN dotnet restore "e-mood-dotnet/e-mood-dotnet.csproj"
COPY . .
WORKDIR "/src/e-mood-dotnet"
RUN dotnet build "e-mood-dotnet.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "e-mood-dotnet.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
ENV DOTNET_HOSTBUILDER__RELOADCONFIGONCHANGE=false
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "e-mood-dotnet.dll"]

