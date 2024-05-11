using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Types;

public class LocationServices
{
    [JsonPropertyName("access")]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<LocationServiceAccess>))]
    public LocationServiceAccess Access { get; set; }

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<LocationServiceStatus>))]
    public LocationServiceStatus Status { get; set; }
}