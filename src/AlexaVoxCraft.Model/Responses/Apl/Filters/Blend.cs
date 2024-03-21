using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Blend : ImageFilter
{
    [JsonPropertyName("destination"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Destination { get; set; }

    [JsonPropertyName("source"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Source { get; set; }

    [JsonPropertyName("mode"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<BlendMode?> Mode { get; set; }
}