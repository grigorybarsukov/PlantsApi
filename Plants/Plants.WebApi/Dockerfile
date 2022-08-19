FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Plants.WebApi/Plants.WebApi.csproj", "Plants.WebApi/"]
RUN dotnet restore "Plants.WebApi/Plants.WebApi.csproj"
COPY . .
WORKDIR "/src/Plants.WebApi"
RUN dotnet build "Plants.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Plants.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Plants.WebApi.dll"]
