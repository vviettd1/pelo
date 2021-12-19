FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pelo.Api/Pelo.Api.csproj", "Pelo.Api/"]
RUN dotnet restore "Pelo.Api/Pelo.Api.csproj"
COPY . .
WORKDIR "/src/Pelo.Api"
RUN dotnet build "Pelo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pelo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pelo.Api.dll"]
