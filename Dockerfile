FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files and restore dependencies
COPY ["BlueWhatsapp.Api/BlueWhatsapp.Api.csproj", "BlueWhatsapp.Api/"]
COPY ["BlueWhatsapp.Boundaries/BlueWhatsapp.Boundaries.csproj", "BlueWhatsapp.Boundaries/"]
COPY ["BlueWhatsapp.Core/BlueWhatsapp.Core.csproj", "BlueWhatsapp.Core/"]

# Restore only the API project and its dependencies
RUN dotnet restore "BlueWhatsapp.Api/BlueWhatsapp.Api.csproj"

# Copy the rest of the source code
COPY . .

# Build and publish
RUN dotnet publish "BlueWhatsapp.Api/BlueWhatsapp.Api.csproj" -c Release -o /app/publish

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Create directory for SQLite database
RUN mkdir -p /app/data
VOLUME /app/data

# Copy the published application
COPY --from=build /app/publish .

# Ensure appsettings.json is properly copied and has correct permissions
RUN chmod 644 appsettings.json

# Set environment variables
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production
ENV SQLite__DatabasePath=/app/data/WhatsappApp.db

# Expose port 80
EXPOSE 80

# Set the entry point
CMD ["dotnet", "BlueWhatsapp.Api.dll"]