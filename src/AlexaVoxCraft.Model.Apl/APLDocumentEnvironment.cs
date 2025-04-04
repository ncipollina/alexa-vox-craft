using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Components;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLDocumentEnvironment
{
    [JsonProperty("lang",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Lang { get; set; }

    [JsonProperty("layoutDirection", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<LayoutDirection?> LayoutDirection { get; set; }

    [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(ParameterListConverter), true)]
    public IList<Parameter> Parameters { get; set; }
}