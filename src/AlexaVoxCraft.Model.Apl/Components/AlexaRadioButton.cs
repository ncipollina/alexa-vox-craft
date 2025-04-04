using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaRadioButton:APLComponent
{
    [JsonProperty("type")]
    public override string Type => nameof(AlexaRadioButton);

    [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

    [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Theme { get; set; }

    [JsonProperty("radioButtonColor",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> RadioButtonColor { get; set; }

    [JsonProperty("radioButtonHeight",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue RadioButtonHeight { get; set; }

    [JsonProperty("radioButtonWidth", NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue RadioButtonWidth { get; set; }
}