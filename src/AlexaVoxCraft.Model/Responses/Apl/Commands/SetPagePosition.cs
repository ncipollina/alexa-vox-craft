using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<SetPagePosition>))]
public enum SetPagePosition
{
    [EnumMember(Value="absolute")]
    Absolute,
    [EnumMember(Value="relative")]
    Relative
}