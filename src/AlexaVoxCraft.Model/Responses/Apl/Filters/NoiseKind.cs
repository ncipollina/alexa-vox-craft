using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Filters;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<NoiseKind>))]
public enum NoiseKind
{
    [EnumMember(Value="gaussian")]
    Gaussian,
    [EnumMember(Value="uniform")]
    Uniform
}