﻿using BlueWhatsapp.Api.models.DTO.Messages;

namespace BlueWhatsapp.Api.models.DTO;

/// <summary>
/// The WhatsApp Cloud Model
/// </summary>
public sealed class WhatsAppCloudModel
{
    /// <summary>
    /// The entry of the WhatsApp Cloud Model
    /// </summary>
    public List<Entry> Entry { get; set; } = Enumerable.Empty<Entry>().ToList();

    /// <summary>
    /// Get the message from the entry
    /// </summary>
    /// <returns></returns>
    public Message? GetMessage()
    {
        return Entry[0]?.Changes[0]?.Value?.Messages[0];
    }

    /// <summary>
    /// Get the from of the message
    /// </summary>
    /// <returns></returns>
    public string GetFrom()
    {
        return Entry[0]?.Changes[0]?.Value?.Messages[0]?.From;
    }

    /// <summary>
    /// Get the contact profile name
    /// </summary>
    /// <returns></returns>
    public string? GetContactProfileName()
    {
        return Entry[0]?.Changes[0]?.Value?.Contacts[0]?.Profile?.Name;
    }
}