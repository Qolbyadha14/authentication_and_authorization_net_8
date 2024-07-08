#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["sample-auth-using-jwt/sample-auth-using-jwt.csproj", "sample-auth-using-jwt/"]
RUN dotnet restore "./sample-auth-using-jwt/sample-auth-using-jwt.csproj"
COPY . .
WORKDIR "/src/sample-auth-using-jwt"
RUN dotnet build "./sample-auth-using-jwt.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./sample-auth-using-jwt.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sample-auth-using-jwt.dll"]