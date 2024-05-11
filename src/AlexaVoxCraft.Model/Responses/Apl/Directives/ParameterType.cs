using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ParameterType>))]
public enum ParameterType
{
    [EnumMember(Value = "any")]
    Any,
    [EnumMember(Value = "array")]
    Array,
    [EnumMember(Value = "boolean")]
    Boolean,
    [EnumMember(Value = "color")]
    Color,
    [EnumMember(Value = "component")]
    Component,
    [EnumMember(Value = "dimension")]
    Dimension,
    [EnumMember(Value = "integer")]
    Integer,
    [EnumMember(Value = "map")]
    Map,
    [EnumMember(Value = "number")]
    Number,
    [EnumMember(Value = "object")]
    Object,
    [EnumMember(Value = "string")]
    String
}