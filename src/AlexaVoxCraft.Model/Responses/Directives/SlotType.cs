using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class SlotType
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("values")]
    public SlotTypeValue[] Values { get; set; }
}