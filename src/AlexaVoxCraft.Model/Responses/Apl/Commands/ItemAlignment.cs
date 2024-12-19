using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ItemAlignment>))]
public enum ItemAlignment
{
    [EnumMember(Value="first")]
    First,
    [EnumMember(Value = "center")]
    Center,
    [EnumMember(Value = "last")]
    Last,
    [EnumMember(Value = "visible")]
    Visible
}