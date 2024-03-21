using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Grayscale : ImageFilter
{
    [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> Amount { get; set; }

    [JsonPropertyName("source"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Source { get; set; }
}