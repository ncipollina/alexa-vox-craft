using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<LayoutDirection>))]
public enum LayoutDirection
{
    [EnumMember(Value="inherit")]
    Inherit,
    [EnumMember(Value="LTR")]
    LTR,
    [EnumMember(Value = "RTL")]
    RTL
}