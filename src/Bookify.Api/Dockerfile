FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bookify.Api/Bookify.Api.csproj", "src/Bookify.Api/"]
COPY ["src/Bookify.Application/Bookify.Application.csproj", "src/Bookify.Application/"]
COPY ["src/Bookify.Domain/Bookify.Domain.csproj", "src/Bookify.Domain/"]
COPY ["src/Bookify.Infrastructure/Bookify.Infrastructure.csproj", "src/Bookify.Infrastructure/"]
RUN dotnet restore "./src/Bookify.Api/./Bookify.Api.csproj"
COPY . .
WORKDIR "/src/src/Bookify.Api"
RUN dotnet build "./Bookify.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bookify.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bookify.Api.dll"]