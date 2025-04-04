using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLViewportSize
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("pixelHeight")]
    public int PixelHeight { get; set; }

    [JsonProperty("pixelWidth")]
    public int PixelWidth { get; set; }
}