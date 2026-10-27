FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Arishma.Auth.Api/Arishma.Auth.Api.csproj src/Arishma.Auth.Api/
COPY src/Arishma.Auth.Application/Arishma.Auth.Application.csproj src/Arishma.Auth.Application/
COPY src/Arishma.Auth.Domain/Arishma.Auth.Domain.csproj src/Arishma.Auth.Domain/
COPY src/Arishma.Auth.Infrastructure/Arishma.Auth.Infrastructure.csproj src/Arishma.Auth.Infrastructure/
RUN dotnet restore src/Arishma.Auth.Api/Arishma.Auth.Api.csproj
COPY . .
RUN dotnet publish src/Arishma.Auth.Api/Arishma.Auth.Api.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://*:5001
ENTRYPOINT ["dotnet", "Arishma.Auth.Api.dll"]
