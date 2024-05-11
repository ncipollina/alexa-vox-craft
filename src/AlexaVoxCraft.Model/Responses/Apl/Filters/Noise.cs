using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Noise : ImageFilter
{
    [JsonPropertyName("useColor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> UseColor { get; set; }

    [JsonPropertyName("sigma"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Sigma { get; set; }

    [JsonPropertyName("kind"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<NoiseKind?> Kind { get; set; }
}