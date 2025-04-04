using System;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

[Obsolete("This command is deprecated, and no longer the correct way to change state")]
public class SetState:APLCommand
{
    public override string Type => nameof(SetState);

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("state")]
    public APLValue<SetStateStates> State { get; set; }

    [JsonProperty("value")]
    public APLValue<bool> Value { get; set; }
}