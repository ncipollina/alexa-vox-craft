using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaSlider : AlexaSliderBase
{
 [JsonPropertyName("sliderId")] public APLValue<string> SliderId { get; set; }

 [JsonPropertyName("metadataPosition"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<MetadataPosition?> MetadataPosition { get; set; }

 [JsonPropertyName("iconLeftGraphicSource"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<string> IconLeftGraphicSource { get; set; }

 [JsonPropertyName("iconRightGraphicSource"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<string> IconRightGraphicSource { get; set; }

 [JsonPropertyName("sliderSize"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<SliderSize?> SliderSize { get; set; }

 [JsonPropertyName("sliderType"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<SliderType?> SliderType { get; set; }

 [JsonPropertyName("sliderMoveMillisecond"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
 public APLValue<int?> SliderMoveMillisecond { get; set; }
}