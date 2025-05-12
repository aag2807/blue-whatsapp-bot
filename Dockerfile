FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /src

# Add maintainer and repository information
LABEL maintainer="aagn2807"
LABEL org.opencontainers.image.source="https://github.com/aag2807/blue-whatsapp-bot/"
LABEL org.opencontainers.image.description="Blue WhatsApp Transportation Bot"

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
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS runtime
WORKDIR /app

# Install ICU libraries for globalization support
RUN apk add --no-cache icu-libs

# Set globalization invariant mode to false to use system's globalization libraries
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Install SQLite tools
RUN apk add --no-cache sqlite

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

# Create the SQLite database file
RUN touch /app/WhatsappApp.db
RUN chmod 666 /app/WhatsappApp.db

# Create a helper script for database inspection
RUN echo '#!/bin/sh\n\
echo "SQLite Database Inspection Tool"\n\
echo "Available commands:"\n\
echo "1. List all tables: .tables"\n\
echo "2. Show table schema: .schema table_name"\n\
echo "3. Show all data in a table: SELECT * FROM table_name;"\n\
echo "4. Exit: .quit"\n\
echo "Enter SQLite command or .help for more options:"\n\
sqlite3 /app/WhatsappApp.db' > /app/inspect-db.sh && \
chmod +x /app/inspect-db.sh

# Expose port 80
EXPOSE 80

# Set the entry point
CMD ["dotnet", "BlueWhatsapp.Api.dll"]