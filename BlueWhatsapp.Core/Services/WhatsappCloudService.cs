using System.Net.Http.Headers;
using System.Text;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Messages.Interactive;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Options;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace BlueWhatsapp.Core.Services;

public sealed class WhatsappCloudService(IAppLogger logger, IOptions<WhatsAppCloudOptions> options) : IWhatsappCloudService
{
    private readonly WhatsAppCloudOptions _options = options.Value;

    /// <inheritdoc />
    async Task<bool> IWhatsappCloudService.SendMessage<T>(T model)
    {
        // Validate configuration
        if (string.IsNullOrEmpty(_options.AccessToken))
        {
            logger.LogError("WhatsApp Cloud API AccessToken is not configured");
            return false;
        }

        if (string.IsNullOrEmpty(_options.PhoneNumberId))
        {
            logger.LogError("WhatsApp Cloud API PhoneNumberId is not configured");
            return false;
        }

        string json = JsonConvert.SerializeObject(model);
        byte[] byteData = Encoding.UTF8.GetBytes(json);

        using var client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(_options.TimeoutSeconds);
        
        using var content = new ByteArrayContent(byteData);
        string uri = $"{_options.BaseEndpoint}/{_options.PhoneNumberId}/messages";

        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_options.AccessToken}");

        if (_options.EnableLogging)
        {
            logger.LogInfo($"Sending WhatsApp message to {uri}");
            logger.LogInfo($"Request payload: {json}");
        }

        HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(true);
        string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        if (_options.EnableLogging)
        {
            logger.LogInfo($"WhatsApp API Response Status: {response.StatusCode}");
            logger.LogInfo($"WhatsApp API Response: {responseContent}");
        }

        if (responseContent != null)
        {
            object? data = JsonConvert.DeserializeObject<object>(responseContent);
            if (!response.IsSuccessStatusCode)
            {
                logger.LogError($"WhatsApp API Error: {data}");
            }
        }
        
        return response.IsSuccessStatusCode;
    }

}