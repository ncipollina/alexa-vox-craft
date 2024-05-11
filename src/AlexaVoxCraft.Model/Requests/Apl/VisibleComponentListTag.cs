using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponentListTag
{
    [JsonPropertyName("itemCount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ItemCount { get; set; }

    [JsonPropertyName("lowestIndexSeen"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? LowestIndexSeen { get; set; }

    [JsonPropertyName("highestIndexSeen"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? HighestIndexSeen { get; set; }

    [JsonPropertyName("lowestOrdinalSeen"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? LowestOrdinalSeen { get; set; }

    [JsonPropertyName("highestOrdinalSeen"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? HighestOrdinalSeen { get; set; }
}