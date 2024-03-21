using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<TextOverflow>))]
public enum TextOverflow
{
    [EnumMember(Value= "marquee")]
    Marquee,
    [EnumMember(Value="wrap")]
    Wrap
}