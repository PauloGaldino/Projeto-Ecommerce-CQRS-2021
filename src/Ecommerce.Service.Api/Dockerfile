#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Ecommerce.Service.Api/Ecommerce.Service.Api.csproj", "src/Ecommerce.Service.Api/"]
RUN dotnet restore "src/Ecommerce.Service.Api/Ecommerce.Service.Api.csproj"
COPY . .
WORKDIR "/src/src/Ecommerce.Service.Api"
RUN dotnet build "Ecommerce.Service.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ecommerce.Service.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce.Service.Api.dll"]