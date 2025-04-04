using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaImageList: AlexaImageListBase
{
    public override string Type => nameof(AlexaImageList);

    [JsonProperty("defaultImageSource",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> DefaultImageSource { get; set; }

    [JsonProperty("listItems",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<IList<AlexaImageListItem>> ListItems { get; set; }

    [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> VideoAudioTrack { get; set; }

    [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> VideoAutoPlay { get; set; }

    [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Lang { get; set; }
}