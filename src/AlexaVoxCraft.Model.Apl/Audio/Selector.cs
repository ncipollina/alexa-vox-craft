using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio;

public class Selector : APLAMultiChildComponent
{
    [JsonProperty("strategy",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<SelectorStrategy?> Strategy { get; set; }

    public override string Type => "Selector";
}