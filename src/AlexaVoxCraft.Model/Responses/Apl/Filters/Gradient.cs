using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Gradient : ImageFilter
{
    [JsonPropertyName("gradient"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<APLGradient> SelectedGradient { get; set; }
}