using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;
using AlexaVoxCraft.Model.Responses.Apl.Filters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class Image : APLComponent
{
    [JsonPropertyName("align"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Align { get; set; }

    [JsonPropertyName("borderRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderRadius { get; set; }

    [JsonPropertyName("overlayGradient"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<APLGradient> OverlayGradient { get; set; }

    [JsonPropertyName("overlayColor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> OverlayColor { get; set; }

    [JsonPropertyName("scale"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<Scale?> Scale { get; set; }

    [JsonPropertyName("sources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<string>> Sources{ get; set; }

    [JsonPropertyName("filters"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<ImageFilter>> Filters { get; set; }

}