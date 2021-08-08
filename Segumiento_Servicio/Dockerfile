#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Segumiento_Servicio/Segumiento_Servicio.csproj", "Segumiento_Servicio/"]
RUN dotnet restore "Segumiento_Servicio/Segumiento_Servicio.csproj"
COPY . .
WORKDIR "/src/Segumiento_Servicio"
RUN dotnet build "Segumiento_Servicio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Segumiento_Servicio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Segumiento_Servicio.dll"]