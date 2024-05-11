using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ViewportTheme>))]
public enum ViewportTheme
{
    [EnumMember(Value="dark")]
    Dark,
    [EnumMember(Value="light")]
    Light
}