using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaSlider : AlexaSliderBase
{
    public override string Type => nameof(AlexaSlider);

    [JsonProperty("sliderId")]
    public APLValue<string> SliderId { get; set; }

    [JsonProperty("metadataPosition", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<MetadataPosition?> MetadataPosition { get; set; }

    [JsonProperty("iconLeftGraphicSource", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> IconLeftGraphicSource { get; set; }

    [JsonProperty("iconRightGraphicSource", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> IconRightGraphicSource { get; set; }

    [JsonProperty("sliderSize", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<SliderSize?> SliderSize { get; set; }

    [JsonProperty("sliderType", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<SliderType?> SliderType { get; set; }

    [JsonProperty("sliderMoveMillisecond", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> SliderMoveMillisecond { get; set; }
}