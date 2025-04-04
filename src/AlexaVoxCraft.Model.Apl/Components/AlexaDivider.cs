using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaDivider:APLComponent
{
    [JsonProperty("type")]
    public override string Type => nameof(AlexaDivider);

    [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Theme { get; set; }
}