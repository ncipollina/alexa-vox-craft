﻿using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Filters;

public class Saturate : IImageFilter
{
    [JsonProperty("type")]
    public string Type => nameof(Saturate);

    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<double?> Amount { get; set; }

    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Source { get; set; }
}