using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class AlexaImageListBase : ResponsiveTemplate
{
    [JsonPropertyName("imageAlignment"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

    [JsonPropertyName("imageAspectRatio"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

    [JsonPropertyName("imageBlurredBackground"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ImageBlurredBackground { get; set; }

    [JsonPropertyName("imageHideScrim"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ImageHideScrim { get; set; }

    [JsonPropertyName("imageMetadataPrimacy"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ImageMetadataPrimacy { get; set; }

    [JsonPropertyName("imageRoundedCorner"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ImageRoundedCorner { get; set; }

    [JsonPropertyName("imageScale"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<Scale?> ImageScale { get; set; }

    [JsonPropertyName("primaryAction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> PrimaryAction { get; set; }

    [JsonPropertyName("headerAttributionOpacity"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> HeaderAttributionOpacity { get; set; }

    [JsonPropertyName("listId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ListId { get; set; }

    [JsonPropertyName("speechItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SpeechItems { get; set; }
}