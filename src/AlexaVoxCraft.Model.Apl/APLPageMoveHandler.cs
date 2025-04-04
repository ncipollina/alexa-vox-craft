using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLPageMoveHandler
{
    [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> When { get; set; }

    [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Commands { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }

    [JsonProperty("drawOrder",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<DrawOrder?> DrawOrder { get; set; }
}