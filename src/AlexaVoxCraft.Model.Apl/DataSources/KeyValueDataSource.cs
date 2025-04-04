using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataSources;

public class KeyValueDataSource:APLDataSource
{
    [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
    public override string Type { get; }

    [JsonExtensionData]
    public Dictionary<string,object> Properties { get; set; }
}