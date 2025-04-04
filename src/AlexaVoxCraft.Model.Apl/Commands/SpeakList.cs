using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class SpeakList : APLCommand
{
    public override string Type => nameof(SpeakList);

    [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<ItemAlignment?> Align { get; set; }

    [JsonProperty("componentId")]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("start")]
    public APLValue<int> Start { get; set; }

    [JsonProperty("count")]
    public APLValue<int> Count { get; set; }

    [JsonProperty("minimumDwellTime",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> MinimumDwellTime { get; set; }

}