using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

public class Blur : ImageFilter
{
    [JsonPropertyName("radius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Radius { get; set; }

}