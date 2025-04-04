using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaSliderRadial : AlexaSliderBase
{
    public override string Type => nameof(AlexaSliderRadial);

    [JsonProperty("useDefaultSliderExpandTransition", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> UseDefaultSliderExpandTransition { get; set; }
}