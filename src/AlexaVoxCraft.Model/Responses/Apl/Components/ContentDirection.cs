using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ContentDirection>))]
public enum ContentDirection
{
    [EnumMember(Value = "column")] Column,
    [EnumMember(Value = "row")] Row
}