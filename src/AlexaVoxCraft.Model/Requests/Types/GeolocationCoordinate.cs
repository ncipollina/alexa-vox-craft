using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types;

public class GeolocationCoordinate
{
    [JsonPropertyName("latitudeInDegrees")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitudeInDegrees")]
    public double Longitude { get; set; }

    [JsonPropertyName("accuracyInMeters")]
    public double Accuracy { get; set; }
}