using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponentListItemTag
{
    [JsonPropertyName("index"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Index { get; set; }
}