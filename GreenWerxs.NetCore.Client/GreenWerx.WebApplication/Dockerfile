#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GreenWerx.WebApplication/GreenWerx.WebApplication.csproj", "GreenWerx.WebApplication/"]
COPY ["../../../Common/GreenWerx.NetCore.Models/GreenWerx.NetCore.Models/GreenWerx.NetCore.Models.csproj", "../../../Common/GreenWerx.NetCore.Models/GreenWerx.NetCore.Models/"]
RUN dotnet restore "GreenWerx.WebApplication/GreenWerx.WebApplication.csproj"
COPY . .
WORKDIR "/src/GreenWerx.WebApplication"
RUN dotnet build "GreenWerx.WebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GreenWerx.WebApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GreenWerx.WebApplication.dll"]