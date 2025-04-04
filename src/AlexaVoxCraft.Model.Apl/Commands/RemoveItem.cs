using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class RemoveItem : APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(RemoveItem);

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }
}