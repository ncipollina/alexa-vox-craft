using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class SimpleCard : Card
{
    [JsonPropertyName("title")]
    [JsonRequired]
    public string Title { get; set; }

    [JsonRequired]
    [JsonPropertyName("content")]
    public string Content { get; set; }
}