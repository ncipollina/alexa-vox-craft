using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ViewportShape
{
    RECTANGLE,
    ROUND
}