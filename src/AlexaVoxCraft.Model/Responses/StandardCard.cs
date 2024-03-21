using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class StandardCard : Card
{
    [JsonRequired]
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonRequired]
    [JsonPropertyName("text")]
    public string Content { get; set; }

    [JsonPropertyName("image")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CardImage Image { get; set; }
}