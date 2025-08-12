using System.Net.Http.Headers;
using System.Text;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Messages.Interactive;
using BlueWhatsapp.Core.Models.Schedule;
using Newtonsoft.Json;

namespace BlueWhatsapp.Core.Services;

public sealed class WhatsappCloudService(IAppLogger logger) : IWhatsappCloudService
{
    /// <inheritdoc />
    async Task<bool> IWhatsappCloudService.SendMessage<T>(T model)
    {
        string  json = JsonConvert.SerializeObject(model);
        byte[] byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model));
        using var client = new HttpClient();
        using var content = new ByteArrayContent(byteData);

        string endpoint = "https://graph.facebook.com/v22.0";
        string phoneNumberId = "559595107241645";
        string accessToken =
            "EAAN28uo8ybUBO46hVhzVgyrZApjV8fjnoz37sNKsMOz8JZB1YfcNxsO0pOezTXKwijfKQJ2UzviE4BfbXOZCTsQpDYOX0xKApZB7gJlwCtmIbLNmofV6vr2qZCDC6I7KSEZC36cJye7oZChUqUU4NPSNfFYKluPcxhsdNhSifroVVQ3ntMlZAh9ZBEOFpz6NxII87RgZDZD";
        string uri = $"{endpoint}/{phoneNumberId}/messages";

        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

        HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(true);
        string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        if (responseContent != null)
        {
            object? data = JsonConvert.DeserializeObject<object>(responseContent);
            if (!response.IsSuccessStatusCode)
            {
                logger.LogError(data);
            }
        }
        
        return response.IsSuccessStatusCode;
    }

}