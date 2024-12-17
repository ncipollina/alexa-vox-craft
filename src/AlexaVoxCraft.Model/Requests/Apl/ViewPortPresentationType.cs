using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ViewPortPresentationType
{
    STANDARD,
    OVERLAY
}