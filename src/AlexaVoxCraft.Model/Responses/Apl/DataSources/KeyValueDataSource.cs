using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class KeyValueDataSource : APLDataSource
{
    [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Type => null!;

    [JsonExtensionData] public Dictionary<string, object> Properties { get; set; }
}