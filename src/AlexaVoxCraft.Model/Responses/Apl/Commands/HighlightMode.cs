using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<HighlightMode>))]
public enum HighlightMode
{
    [EnumMember(Value="line")]
    Line,
    [EnumMember(Value = "block")]
    Block
}