using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaLists : AlexaImageListBase
{
    [JsonPropertyName("defaultImageSource"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> DefaultImageSource { get; set; }

    [JsonPropertyName("emptyPrimaryText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> EmptyPrimaryText { get; set; }

    [JsonPropertyName("emptySecondaryText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> EmptySecondaryText { get; set; }

    [JsonPropertyName("hideDivider"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> HideDivider { get; set; }

    [JsonPropertyName("listImagePrimacy"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ListImagePrimacy { get; set; }

    [JsonPropertyName("listItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<AlexaListItem>> ListItems { get; set; }

    [JsonPropertyName("touchForward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> TouchForward { get; set; }

    [JsonPropertyName("imageShadow"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ImageShadow { get; set; }

    [JsonPropertyName("lang"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Lang { get; set; }
}