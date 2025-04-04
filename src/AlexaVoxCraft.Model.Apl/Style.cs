using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Apl.JsonConverter;

namespace AlexaVoxCraft.Model.Apl;

public class Style
{
    [JsonPropertyName("extend"), System.Text.Json.Serialization.JsonConverter(typeof(StringOrArrayConverter))]
    public IList<string> Extends { get; set; }

    public bool ShouldSerializeExtends()
    {
        return Extends?.Any() ?? false;
    }

    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Description { get; set; }

    [JsonIgnore()]
    public StyleValue Value
    {
        get => Values?.FirstOrDefault();
        set { Values = new List<StyleValue> { Value }; }
    }

    [JsonPropertyName("values")]
    [JsonConverter(typeof(GenericLegacySingleOrListConverter<StyleValue>))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<StyleValue> Values { get; set; }

    public bool ShouldSerializeValues()
    {
        return Values?.Any() ?? false;
    }
}