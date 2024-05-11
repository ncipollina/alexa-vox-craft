using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ProgressBarType>))]
public enum ProgressBarType
{
    [EnumMember(Value="determinate")]
    Determinate,
    [EnumMember(Value="indeterminate")]
    Indeterminate
}