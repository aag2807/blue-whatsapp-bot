FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src

# Copy only the project files we need
COPY ["BlueWhatsapp.Api/BlueWhatsapp.Api.csproj", "BlueWhatsapp.Api/"]
COPY ["BlueWhatsapp.Boundaries/BlueWhatsapp.Boundaries.csproj", "BlueWhatsapp.Boundaries/"]
COPY ["BlueWhatsapp.Core/BlueWhatsapp.Core.csproj", "BlueWhatsapp.Core/"]

# Restore only the API project and its dependencies
RUN dotnet restore "BlueWhatsapp.Api/BlueWhatsapp.Api.csproj"

# Copy the rest of the source code
COPY . .

# Build the project
RUN dotnet build "BlueWhatsapp.Api/BlueWhatsapp.Api.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "BlueWhatsapp.Api/BlueWhatsapp.Api.csproj" -c Release -o /app/publish

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
WORKDIR /app

# Create directory for SQLite database
RUN mkdir -p /app/data
VOLUME /app/data

# Copy the published application
COPY --from=publish /app/publish .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production
ENV SQLite__DatabasePath=/app/data/WhatsappApp.db

# Expose port 80
EXPOSE 80

# Set the entry point
ENTRYPOINT ["dotnet", "BlueWhatsapp.Api.dll"]