using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class SetPage:APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(SetPage);

    [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("position",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<SetPagePosition> Position { get; set; }

    [JsonProperty("value")]
    public APLValue<int> Value { get; set; }

    [JsonProperty("transitionDuration", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> TransitionDuration { get; set; }
}