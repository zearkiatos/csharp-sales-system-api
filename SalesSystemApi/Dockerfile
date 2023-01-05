FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source
COPY *.sln .
COPY SalesSystemApi/*.csproj ./SalesSystemApi/
COPY SalesSystemApi/. ./SalesSystemApi/
COPY SalesSystemApi.Tests/*.csproj ./SalesSystemApi.Tests/
COPY SalesSystemApi.Tests/. ./SalesSystemApi.Tests/
RUN dotnet sln remove ./SalesSystemApi.Tests/*.csproj
WORKDIR /source/SalesSystemApi
RUN dotnet restore
RUN dotnet publish -c release -o app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build source/SalesSystemApi/app .
EXPOSE 80
ENTRYPOINT ["dotnet", "SalesSystemApi.dll",  "--urls", "http://*:80"]