using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<SubmitKeyType>))]
public enum SubmitKeyType
{
    [EnumMember(Value = "done")] Done,
    [EnumMember(Value = "go")] Go,
    [EnumMember(Value = "next")] Next,
    [EnumMember(Value = "search")] Search,
    [EnumMember(Value = "send")] Send
}