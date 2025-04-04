using System;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class TextTrack
{
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Type { get; } = "caption";

    [JsonProperty("url")]
    public APLValue<Uri> Uri { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }
}