using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class AlexaExtensions
{
    [JsonProperty("available",NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string,object> Available { get; set; }
}