using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ScrollDirection>))]
public enum ScrollDirection
{
    [EnumMember(Value="horizontal")]
    Horizontal,
    [EnumMember(Value="vertical")]
    Vertical
}