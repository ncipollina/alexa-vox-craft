using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class ControlMedia:APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(ControlMedia);

    [JsonProperty("command")]
    public APLValue<ControlMediaCommand> Command { get; set; }

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Value { get; set; }

}