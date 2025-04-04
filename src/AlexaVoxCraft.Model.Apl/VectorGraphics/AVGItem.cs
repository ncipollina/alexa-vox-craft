using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Apl.VectorGraphics.Filters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.VectorGraphics;

public abstract class AVGItem:IAVGItem
{
    [JsonProperty("type")]
    public abstract string Type { get; }

    [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(AvgFilterListConverter))]
    public APLValue<IList<IAVGFilter>> Filters { get; set; }
}