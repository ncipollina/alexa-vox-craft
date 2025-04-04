using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaCheckbox:APLComponent{
    [JsonProperty("type")]
    public override string Type => nameof(AlexaCheckbox);

    [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

    [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Theme { get; set; }

    [JsonProperty("selectedColor", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> SelectedColor { get; set; }

    [JsonProperty("checkboxHeight", NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue CheckboxHeight { get; set; }

    [JsonProperty("checkboxWidth", NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue CheckboxWidth { get; set; }

    [JsonProperty("isIndeterminate", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> IsIndeterminate { get; set; }
}