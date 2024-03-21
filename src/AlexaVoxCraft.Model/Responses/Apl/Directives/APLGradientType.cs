using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<APLGradientType>))]
public enum APLGradientType
{
    [EnumMember(Value="linear")]
    Linear,
    [EnumMember(Value = "radial")]
    Radial
}