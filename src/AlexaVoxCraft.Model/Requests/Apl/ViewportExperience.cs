using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class ViewportExperience
{
    [JsonPropertyName("canResize")]
    public bool CanResize { get; set; }

    [JsonPropertyName("canRotate")]
    public bool CanRotate { get; set; }

    [JsonPropertyName("arcMinuteWidth")]
    [Obsolete("ArcMinuteWidth is deprecated. Use the Mode property to determine the view distance and available modalities for the device instead.")]
    public int ArcMinuteWidth { get; set; }

    [JsonPropertyName("arcMinuteHeight")]
    [Obsolete("ArcMinuteHeight is deprecated. Use the Mode property to determine the view distance and available modalities for the device instead.")]
    public int ArcMinuteHeight { get; set; }
}