using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Parameter : IStringConvertable<Parameter>
{
    public Parameter()
    {
    }

    public Parameter(string name) => Name = name;
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("type")]
    public ParameterType Type { get; set; }
    
    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }
    
    [JsonPropertyName("default"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object Default { get; set; }

    public static Parameter FromString(string value) => value;

    public static implicit operator Parameter(string value) => new(value);
    
    public bool ShouldSerializeAsString() => Type == ParameterType.Any;
    
    public override string ToString() => Name;
}