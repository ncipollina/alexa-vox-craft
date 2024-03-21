using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Color : ImageFilter
{
    [JsonPropertyName("color"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SelectedColor { get; set; }
}