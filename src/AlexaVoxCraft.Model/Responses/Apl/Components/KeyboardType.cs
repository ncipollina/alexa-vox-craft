using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<KeyboardType>))]
public enum KeyboardType
{
    [EnumMember(Value = "decimalPad")] DecimalPad,
    [EnumMember(Value = "emailAddress")] EmailAddress,
    [EnumMember(Value = "normal")] Normal,
    [EnumMember(Value = "numberPad")] NumberPad,
    [EnumMember(Value = "phonePad")] PhonePad,
    [EnumMember(Value = "url")] Url
}