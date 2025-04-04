using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio;

public class Silence : APLAComponent
{
    public override string Type => nameof(Silence);

    [JsonProperty("duration",NullValueHandling = NullValueHandling.Ignore)]
    public new APLValue<int?> Duration { get; set; }
}