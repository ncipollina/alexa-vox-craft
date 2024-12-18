using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaOrdinal : APLComponent
{
    [JsonPropertyName("ordinalText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> OrdinalText { get; set; }

    [JsonPropertyName("theme"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Theme { get; set; }
}