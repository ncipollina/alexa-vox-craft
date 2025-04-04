using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public abstract class AlexaPaginatedListItem:AlexaListItem
{
    [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> SecondaryText { get; set; }

    [JsonProperty("tertiaryText", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> TertiaryText { get; set; }
}