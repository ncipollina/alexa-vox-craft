using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<RatingGraphicType>))]
public enum RatingGraphicType
{
    [EnumMember(Value = "AVG")] AVG,
    [EnumMember(Value = "image")] Image
}