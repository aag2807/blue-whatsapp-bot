# Docker Configuration Guide for Blue WhatsApp Bot

This guide explains how to configure and run the Blue WhatsApp Bot using Docker with proper environment variable configuration.

## Quick Start

### 1. Using Docker Compose (Recommended)

1. **Copy the environment template:**
   ```bash
   cp env.example .env
   ```

2. **Edit the `.env` file with your WhatsApp credentials:**
   ```bash
   # Required: Your WhatsApp Business credentials
   WHATSAPP_ACCESS_TOKEN=your_actual_whatsapp_access_token
   WHATSAPP_PHONE_NUMBER_ID=your_actual_phone_number_id
   ```

3. **Run the application:**
   ```bash
   docker-compose up -d
   ```

4. **Access the application:**
   - API: http://localhost:8080
   - Health check: http://localhost:8080/health

### 2. Using Docker Run

```bash
docker build -t blue-whatsapp-bot .

docker run -d \
  --name blue-whatsapp-bot \
  -p 8080:80 \
  -e WhatsAppCloud__AccessToken="your_access_token" \
  -e WhatsAppCloud__PhoneNumberId="your_phone_number_id" \
  -e WhatsAppCloud__VerifyToken="your_verify_token" \
  -v $(pwd)/data:/app/data \
  blue-whatsapp-bot
```

## Configuration Options

### Required Environment Variables

| Variable | Description | Example |
|----------|-------------|---------|
| `WhatsAppCloud__AccessToken` | WhatsApp Business API access token | `EAAN28uo8ybU...` |
| `WhatsAppCloud__PhoneNumberId` | Your WhatsApp Business phone number ID | `559595107241645` |
| `WhatsAppCloud__VerifyToken` | Webhook verify token (you choose this) | `my_secure_token_123` |

### Optional Environment Variables

| Variable | Description | Default |
|----------|-------------|---------|
| `WhatsAppCloud__BaseEndpoint` | WhatsApp API base URL | `https://graph.facebook.com/v22.0` |
| `WhatsAppCloud__ApiVersion` | API version to use | `v22.0` |
| `WhatsAppCloud__TimeoutSeconds` | HTTP timeout in seconds | `30` |
| `WhatsAppCloud__EnableLogging` | Enable API request/response logging | `true` |

## Getting WhatsApp Credentials

### Access Token
1. Go to [Facebook Developers](https://developers.facebook.com/)
2. Navigate to your WhatsApp Business app
3. Go to WhatsApp > API Setup
4. Copy the temporary access token or generate a permanent one

### Phone Number ID
1. In the same WhatsApp API Setup page
2. Look for "From" phone number
3. The Phone Number ID is displayed next to your phone number

## Production Deployment

### Security Best Practices

1. **Never commit credentials to version control**
2. **Use environment variables or secrets management**
3. **Rotate access tokens regularly**
4. **Use HTTPS in production**

### Docker Compose Production Example

```yaml
version: '3.8'
services:
  blue-whatsapp-bot:
    build: .
    ports:
      - "80:80"
    environment:
      - ASPNETCORE_ENVIRONMENT=Production
      - WhatsAppCloud__AccessToken=${WHATSAPP_ACCESS_TOKEN}
      - WhatsAppCloud__PhoneNumberId=${WHATSAPP_PHONE_NUMBER_ID}
    volumes:
      - ./data:/app/data
    restart: always
    healthcheck:
      test: ["CMD", "curl", "-f", "http://localhost:80/health"]
      interval: 30s
      timeout: 10s
      retries: 3
```

## Troubleshooting

### Common Issues

1. **"WhatsApp Cloud API AccessToken is not configured"**
   - Ensure the `WhatsAppCloud__AccessToken` environment variable is set
   - Check that the token is valid and not expired

2. **"WhatsApp Cloud API PhoneNumberId is not configured"**
   - Ensure the `WhatsAppCloud__PhoneNumberId` environment variable is set
   - Verify the Phone Number ID is correct

3. **Container won't start**
   - Check Docker logs: `docker logs blue-whatsapp-bot`
   - Verify all required environment variables are set

4. **API requests failing**
   - Enable logging: `WhatsAppCloud__EnableLogging=true`
   - Check container logs for detailed request/response information

### Checking Configuration

You can verify your configuration by checking the application logs:

```bash
docker logs blue-whatsapp-bot
```

Look for log entries that confirm the WhatsApp configuration is loaded correctly.

## Health Monitoring

The application includes a health check endpoint at `/health`. You can monitor the service status:

```bash
curl http://localhost:8080/health
```

## Database Persistence

The SQLite database is stored in `/app/data` inside the container. Make sure to:

1. **Mount a volume** to persist data between container restarts
2. **Backup the database** regularly for production use
3. **Set proper permissions** on the mounted volume

```bash
# Create data directory
mkdir -p ./data

# Copy environment template
cp env.example .env

# Edit .env file with your credentials
# Required:
#   - WHATSAPP_ACCESS_TOKEN
#   - WHATSAPP_PHONE_NUMBER_ID
#   - WHATSAPP_VERIFY_TOKEN

# Run with volume mount
docker run -v $(pwd)/data:/app/data blue-whatsapp-bot
```
