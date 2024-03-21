using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<RatingSlotMode>))]
public enum RatingSlotMode
{
    [EnumMember(Value = "single")] Single,
    [EnumMember(Value = "multiple")] Multiple
}