using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.Backstack;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<BackTypeKind>))]
public enum BackTypeKind
{
    [EnumMember(Value="count")]
    Count,
    [EnumMember(Value = "index")]
    Index,
    [EnumMember(Value = "id")]
    Id
}