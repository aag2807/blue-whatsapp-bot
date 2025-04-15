namespace BlueWhatsapp.Core.Services.ChatService;

public interface IChatResponseService
{
    /// <summary>
    /// Handle The sending of the chat related messages.
    /// </summary>
    /// <returns></returns>
    public Task Execute(string userNumber, string fromName, string userText);
}