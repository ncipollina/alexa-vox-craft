using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<APLDisplay>))]
public enum APLDisplay
{
    [EnumMember(Value="none")]
    None,
    [EnumMember(Value = "normal")]
    Normal,
    [EnumMember(Value = "invisible")]
    Invisible
}