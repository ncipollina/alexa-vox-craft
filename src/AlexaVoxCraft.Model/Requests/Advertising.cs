using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Advertising
{
    [JsonPropertyName("advertisingId")]
    public string AdvertisingId { get; set; }
    [JsonPropertyName("limitAdTracking")]
    public bool LimitAdTracking { get; set; }
}