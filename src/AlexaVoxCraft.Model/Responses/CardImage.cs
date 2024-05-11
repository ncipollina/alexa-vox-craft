using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class CardImage
{
    [JsonPropertyName("smallImageUrl")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string SmallImageUrl { get; set; }

    [JsonPropertyName("largeImageUrl")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string LargeImageUrl { get; set; }
}