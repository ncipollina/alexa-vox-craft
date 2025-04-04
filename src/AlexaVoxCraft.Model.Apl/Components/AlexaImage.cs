using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaImage:APLComponent
{
    [JsonProperty("type")]
    public override string Type => nameof(AlexaImage);

    [JsonProperty("imageAlignment",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

    [JsonProperty("imageAspectRatio",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

    [JsonProperty("imageBlurredBackground",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> ImageBlurredBackground { get; set; }

    [JsonProperty("imageHeight",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue ImageHeight { get; set; }

    [JsonProperty("imageWidth",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue ImageWidth { get; set; }

    [JsonProperty("imageRoundedCorner",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> ImageRoundedCorner { get; set; }

    [JsonProperty("imageScale",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<Scale?> Scale { get; set; }

    [JsonProperty("imageSource",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ImageSource { get; set; }

    [JsonProperty("imageShadow", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> ImageShadow { get; set; }

    [JsonProperty("onLoad", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter), true)]
    public APLValue<IList<APLCommand>> OnLoad { get; set; }

    [JsonProperty("onFail", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter), true)]
    public APLValue<IList<APLCommand>> OnFail { get; set; }
}