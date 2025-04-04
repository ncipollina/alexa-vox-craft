using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class Reinflate : APLCommand
{
    public override string Type => nameof(Reinflate);

    [JsonProperty("preservedSequencers",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string[]> PreservedSequencers { get; set; }
}