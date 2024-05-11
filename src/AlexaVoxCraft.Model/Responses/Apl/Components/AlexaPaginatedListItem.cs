using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class AlexaPaginatedListItem : AlexaListItem
{
    [JsonPropertyName("secondaryText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SecondaryText { get; set; }
    
    [JsonPropertyName("teriaryText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> TertiaryText { get; set; }
}