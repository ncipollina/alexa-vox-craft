using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<DrawOrder>))]
public enum DrawOrder
{
    [EnumMember(Value="nextAbove")]
    NextAbove,
    [EnumMember(Value = "nextBelow")]
    NextBelow,
    [EnumMember(Value = "higherAbove")]
    HigherAbove,
    [EnumMember(Value = "higherBelow")]
    HigherBelow
}