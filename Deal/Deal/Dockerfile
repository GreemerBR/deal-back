#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Deal/DealWebApi.csproj", "Deal/"]
RUN dotnet restore "Deal/DealWebApi.csproj"
COPY . .
WORKDIR "/src/Deal"
RUN dotnet build "DealWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DealWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DealWebApi.dll"]