﻿using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

[JsonConverter(typeof(APLExtensionConverter))]
public class APLExtension
{
    [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("uri",NullValueHandling = NullValueHandling.Ignore)]
    public string Uri { get; set; }

    [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Required { get; set; }
}