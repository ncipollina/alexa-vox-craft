using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Extensions.DataStore;

public class DataStoreSettings
{
    [JsonProperty("dataBindings")] public List<DataBinding> DataBindings { get; set; } = new();
}