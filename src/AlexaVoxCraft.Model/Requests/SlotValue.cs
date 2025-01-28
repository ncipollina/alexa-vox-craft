using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class SlotValue
{
    [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public SlotValueType SlotType { get; set; }

    [JsonPropertyName("value"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Value { get; set; }

    [JsonPropertyName("values"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SlotValue[]? Values { get; set; }

    [JsonPropertyName("resolutions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Resolution? Resolutions { get; set; }
}