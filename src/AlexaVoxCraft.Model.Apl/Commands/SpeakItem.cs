using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class SpeakItem:APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(SpeakItem);

    [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<ItemAlignment?> Align { get; set; }

    [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("highlightMode",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<HighlightMode?> HighlightMode { get; set; }
}