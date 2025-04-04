using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class ScrollToComponent : APLCommand
{
    [JsonProperty("align",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<ItemAlignment> Align { get; set; }

    [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("type")]
    public override string Type => nameof(ScrollToComponent);

    [JsonProperty("targetDuration", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> TargetDuration { get; set; }
}