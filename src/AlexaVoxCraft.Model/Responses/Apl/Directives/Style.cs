using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Style
{
    [JsonPropertyName("extend"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<ConvertableString, IList<ConvertableString>>))]
    public IList<ConvertableString> Extends { get; set; }

    public bool ShouldSerializeExtends()
    {
        return Extends?.Any() ?? false;
    }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    [JsonIgnore]
    public StyleValue Value
    {
        get => Values?.FirstOrDefault();
        set { Values = new List<StyleValue> { Value }; }
    }

    [JsonPropertyName("values"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<StyleValue, IList<StyleValue>>))]
    public IList<StyleValue> Values { get; set; }
}