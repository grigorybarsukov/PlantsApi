FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .

RUN dotnet restore "Plants/Plants.sln"
RUN dotnet build "Plants/Plants.sln" -c Release -o /app/build
RUN dotnet publish "Plants/Plants.WebApi/Plants.WebApi.csproj" -c Release -o /publish

FROM base AS final
COPY --from=build publish/ App/
WORKDIR /app
ENTRYPOINT ["dotnet", "Plants.WebApi.dll"]
