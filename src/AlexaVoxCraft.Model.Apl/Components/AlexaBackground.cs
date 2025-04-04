using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaBackground : ResponsiveTemplate
{
    [JsonProperty("type")]
    public override string Type => nameof(AlexaBackground);

    [JsonProperty("colorOverlay", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> ColorOverlay { get; set; }


    [JsonProperty("overlayGradient", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> OverlayGradient { get; set; }


    [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> VideoAudioTrack { get; set; } = "foreground";


    [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> VideoAutoPlay { get; set; }

}