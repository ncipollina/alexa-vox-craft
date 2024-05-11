using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLGradient
{
    [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public APLGradientType Type { get; set; }
    
    [JsonPropertyName("angle"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Angle { get; set; }
    
    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Description { get; set; }

    [JsonPropertyName("colorRange"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<string>> ColorRange { get; set; }

    [JsonPropertyName("inputRange"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double[] InputRange { get; set; }

}