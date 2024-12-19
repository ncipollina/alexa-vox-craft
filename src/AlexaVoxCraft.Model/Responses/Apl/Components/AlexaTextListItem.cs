using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaTextListItem : AlexaPaginatedListItem
{
    [JsonPropertyName("hideDivider"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> HideDivider { get; set; }

    [JsonPropertyName("secondaryTextPosition"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SecondaryTextPosition { get; set; }

    [JsonPropertyName("tertiaryTextPosition"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> TertiaryTextPosition { get; set; }

    [JsonPropertyName("touchForward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> TouchForward { get; set; }

    [JsonPropertyName("componentSlot"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<Component> ComponentSlot { get; set; }
}