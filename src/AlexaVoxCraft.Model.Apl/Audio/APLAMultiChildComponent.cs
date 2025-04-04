using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio;

public abstract class APLAMultiChildComponent:APLAComponent
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(GenericLegacySingleOrListConverter<object>))]
    public APLValue<IList<object>> Data { get; set; }

    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLAComponentListConverter))]
    public APLValue<IList<APLAComponent>> Items { get; set; }
}