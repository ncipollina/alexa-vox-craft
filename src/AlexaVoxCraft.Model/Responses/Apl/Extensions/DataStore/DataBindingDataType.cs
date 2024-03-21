using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<DataBindingDataType>))]
public enum DataBindingDataType
{
    [EnumMember(Value="OBJECT")]
    Object,
    [EnumMember(Value="ARRAY")]
    Array
}