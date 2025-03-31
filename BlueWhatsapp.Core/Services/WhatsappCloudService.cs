using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace BlueWhatsapp.Core.Services;

public sealed class WhatsappCloudService : IWhatsappCloudService
{
    /// <summary>
    /// 
    /// </summary>
    private readonly IWhatsappCloudService _self;
    
    public WhatsappCloudService()
    {
        _self = this;    
    }
    
    /// <inheritdoc />
    async Task<bool> IWhatsappCloudService.SendMessage<T>(T model)
    {
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

        return response.IsSuccessStatusCode;
    }
}