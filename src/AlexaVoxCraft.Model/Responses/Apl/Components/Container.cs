using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class Container : APLComponent
{
    [JsonPropertyName("alignItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> AlignItems { get; set; }

    [JsonPropertyName("data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<object>> Data { get; set; }

    [JsonPropertyName("direction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Direction { get; set; }

    [JsonPropertyName("firstItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> FirstItem { get; set; }

    [JsonPropertyName("lastItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> LastItem { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Items { get; set; }

    [JsonPropertyName("justifyContent"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> JustifyContent { get; set; }

    [JsonPropertyName("numbered"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> Numbered { get; set; }

    [JsonPropertyName("wrap"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<ContainerWrap?> Wrap { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ContainerWrap>))]
public enum ContainerWrap
{
    [EnumMember(Value="wrapReverse")]
    WrapReverse,
    [EnumMember(Value="noWrap")]
    NoWrap,
    [EnumMember(Value="wrap")]
    Wrap
}