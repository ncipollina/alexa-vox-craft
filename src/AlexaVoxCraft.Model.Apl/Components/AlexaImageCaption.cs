﻿using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaImageCaption:ResponsiveTemplate
{
    public override string Type => nameof(AlexaImageCaption);

    [JsonProperty("attributionImage",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> AttributionImage { get; set; }

    [JsonProperty("buttonStyle",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ButtonStyle { get; set; }

    [JsonProperty("buttonText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ButtonText { get; set; }

    [JsonProperty("headerTitleCanUseTwoLines",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> HeaderTitleCanUseTwoLines { get; set; }

    [JsonProperty("imageAccessibilityLabel",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ImageAccessibilityLabel { get; set; }

    [JsonProperty("imageScrim",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> ImageScrim { get; set; }

    [JsonProperty("imageSource",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ImageSource { get; set; }

    [JsonProperty("primaryText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> PrimaryText { get; set; }

    [JsonProperty("secondaryText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> SecondaryText { get; set; }

    [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

    [JsonProperty("touchForward",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> TouchForward { get; set; }
}