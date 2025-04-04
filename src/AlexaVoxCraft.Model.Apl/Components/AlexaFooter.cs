using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaFooter:APLComponent
{
    public AlexaFooter() { }

    public AlexaFooter(string hintText) : this()
    {
        HintText = hintText;
    }

    [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Theme { get; set; }

    [JsonProperty("hintText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> HintText { get; set; }

    [JsonProperty("type")]
    public override string Type => nameof(AlexaFooter);

    [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Lang { get; set; }
}