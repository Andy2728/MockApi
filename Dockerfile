# Use the official ASP.NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MockApi.csproj", "."]
RUN dotnet restore "MockApi.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "MockApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MockApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MockApi.dll"]
