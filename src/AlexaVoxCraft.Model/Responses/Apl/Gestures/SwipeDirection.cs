using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Gestures;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<SwipeDirection>))]
public enum SwipeDirection
{
    [EnumMember(Value="left")]
    Left,
    [EnumMember(Value="right")]
    Right,
    [EnumMember(Value="up")]
    Up,
    [EnumMember(Value="down")]
    Down,
    [EnumMember(Value="forward")]
    Forward,
    [EnumMember(Value="backward")]
    Backward
}