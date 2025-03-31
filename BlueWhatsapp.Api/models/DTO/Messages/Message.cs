namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Message
{
    /// <summary>
    /// 
    /// </summary>
    public string? From { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Timestamp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Text? Text { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Interactive? Interactive { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string GetUserText()
    {
        string messageType = Type;
        if (messageType.ToUpper() == "TEXT")
        {
            return Text.Body;
        }

        if (messageType.ToUpper() == "INTERACTIVE")
        {
            string interactiveType = Interactive?.Type;

            switch (interactiveType.ToUpper())
            {
                case "LIST_REPLY":
                    return Interactive.List_Reply.Title;
                case "BUTTON_REPLY":
                    return Interactive.Button_Reply.Title;
                default:
                    return string.Empty;
            }
        }

        return string.Empty;
    }
}