using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class StyleValue : IStringConvertable<StyleValue>
{
    public StyleValue()
    {
    }

    public StyleValue(Dictionary<string, object> properties)
    {
        Properties = properties;
    }


    [JsonPropertyName("when"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string When { get; set; }

    [JsonExtensionData] public Dictionary<string, object> Properties { get; set; }
    public static StyleValue FromString(string value)
    {
        throw new NotImplementedException();
    }

    public bool ShouldSerializeAsString() => false;
}