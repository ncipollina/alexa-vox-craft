using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class VisibilityChangeHandler
{
    [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> When { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }

    [JsonProperty("commands"),
     JsonConverter(typeof(APLCommandListConverter), true)]
    public APLValue<IList<APLCommand>> Commands { get; set; }
}