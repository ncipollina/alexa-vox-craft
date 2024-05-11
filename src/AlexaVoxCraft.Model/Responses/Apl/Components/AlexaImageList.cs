using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaImageList : AlexaImageListBase
{
    [JsonPropertyName("defaultImageSource"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> DefaultImageSource { get; set; }

    [JsonPropertyName("listItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<AlexaImageListItem>> ListItems { get; set; }

    [JsonPropertyName("videoAudioTrack"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> VideoAudioTrack { get; set; }

    [JsonPropertyName("videoAutoPlay"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> VideoAutoPlay { get; set; }

    [JsonPropertyName("lang"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Lang { get; set; }
}