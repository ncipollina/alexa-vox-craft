using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<SliderSize>))]
public enum SliderSize
{
    [EnumMember(Value="small")]
    Small,
    [EnumMember(Value="medium")]
    Medium,
    [EnumMember(Value="large")]
    Large
}