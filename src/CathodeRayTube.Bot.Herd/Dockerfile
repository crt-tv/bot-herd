#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/CathodeRayTube.Bot.Herd/CathodeRayTube.Bot.Herd.csproj", "src/CathodeRayTube.Bot.Herd/"]
RUN dotnet restore "src/CathodeRayTube.Bot.Herd/CathodeRayTube.Bot.Herd.csproj"
COPY . .
WORKDIR "/src/src/CathodeRayTube.Bot.Herd"
RUN dotnet build "CathodeRayTube.Bot.Herd.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CathodeRayTube.Bot.Herd.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CathodeRayTube.Bot.Herd.dll"]