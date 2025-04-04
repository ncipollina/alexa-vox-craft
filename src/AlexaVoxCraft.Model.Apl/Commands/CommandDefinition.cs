using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class CommandDefinition
{
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }

    [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(ParameterListConverter),true)]
    public APLValue<IList<Parameter>> Parameters { get; set; }

    [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Commands { get; set; }
}