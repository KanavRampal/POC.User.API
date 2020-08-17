#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["POC.User.API/POC.User.API.csproj", "POC.User.API/"]
RUN dotnet restore "POC.User.API/POC.User.API.csproj"
COPY . .
WORKDIR "/src/POC.User.API"
RUN dotnet build "POC.User.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POC.User.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POC.User.API.dll"]