using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public class Style
{
    [JsonPropertyName("extend")]
    public IList<string> Extends { get; set; }

    public bool ShouldSerializeExtends()
    {
        return Extends?.Any() ?? false;
    }

    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Description { get; set; }

    [JsonIgnore]
    public StyleValue Value
    {
        get => Values?.FirstOrDefault();
        set { Values = new List<StyleValue> { Value }; }
    }

    [JsonPropertyName("values")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<StyleValue>? Values { get; set; }
    
    public static void AddSupport()
    {
        AlexaJsonOptions.RegisterTypeModifier<Style>(info =>
        {
            var valuesProp = info.Properties.FirstOrDefault(p => p.Name == "values");
            if (valuesProp is not null)
            {
                valuesProp.ShouldSerialize = ((obj, _) =>
                {
                    var style = (Style)obj;
                    return style.Values?.Any() ?? false;
                });
                valuesProp.CustomConverter = new GenericSingleOrListConverter<StyleValue>(false);
            }
            var extendProp = info.Properties.FirstOrDefault(p => p.Name == "extend");
            if (extendProp is not null)
            {
                extendProp.CustomConverter = new StringOrArrayConverter(false);
            }
        });
    }
}