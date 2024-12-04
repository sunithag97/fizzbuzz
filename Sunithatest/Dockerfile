FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files and restore any dependencies
COPY *.sln .
COPY FizzBuzzLibrary/*.csproj ./FizzBuzzLibrary/
COPY Sunithatest/*.csproj ./Sunithatest/
RUN dotnet restore

# Copy code
COPY FizzBuzzLibrary/. ./FizzBuzzLibrary/
COPY Sunithatest/. ./Sunithatest/
RUN dotnet build --no-restore
RUN dotnet publish -c Release -o out --no-restore

# runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Sunithatest.dll"]