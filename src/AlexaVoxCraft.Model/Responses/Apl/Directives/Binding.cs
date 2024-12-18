using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Binding
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("value"), JsonConverter(typeof(ObjectConverter))]
    public object Value { get; set; }
    
    [JsonPropertyName("type")]
    public ParameterType Type { get; set; }
}