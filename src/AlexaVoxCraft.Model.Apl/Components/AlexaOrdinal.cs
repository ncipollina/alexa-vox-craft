using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaOrdinal:APLComponent
{
    [JsonProperty("type")] public override string Type => nameof(AlexaOrdinal);

    [JsonProperty("ordinalText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> OrdinalText { get; set; }

    [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Theme { get; set; }
}