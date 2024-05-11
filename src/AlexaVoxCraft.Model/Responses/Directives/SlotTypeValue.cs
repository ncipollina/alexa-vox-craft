using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class SlotTypeValue
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public SlotTypeValueName Name { get; set; }
}