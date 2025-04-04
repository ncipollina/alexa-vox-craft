using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class SetFocus : APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(SetFocus);

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }
}