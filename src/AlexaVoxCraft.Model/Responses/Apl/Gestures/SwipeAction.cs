using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Gestures;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<SwipeAction>))]
public enum SwipeAction
{
    [EnumMember(Value="reveal")]
    Reveal,
    [EnumMember(Value="slide")]
    Slide,
    [EnumMember(Value="cover")]
    Cover
}