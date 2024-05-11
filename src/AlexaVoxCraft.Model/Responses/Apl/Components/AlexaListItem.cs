using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class AlexaListItem : APLComponent
{
    [JsonPropertyName("hideOrdinal"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> HideOrdinal { get; set; }

    [JsonPropertyName("primaryAction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> PrimaryAction { get; set; }

    [JsonPropertyName("primaryText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> PrimaryText { get; set; }

    [JsonPropertyName("theme"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Theme { get; set; }

    [JsonPropertyName("emptyRatingGraphic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> EmptyRatingGraphic { get; set; }

    [JsonPropertyName("fullRatingGraphic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> FullRatingGraphic { get; set; }

    [JsonPropertyName("halfRatingGraphic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> HalfRatingGraphic { get; set; }

    [JsonPropertyName("ratingGraphicType"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<RatingGraphicType?> RatingGraphicType { get; set; }

    [JsonPropertyName("ratingNumber"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> RatingNumber { get; set; }

    [JsonPropertyName("ratingSlotMode"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<RatingSlotMode?> RatingSlotMode { get; set; }

    [JsonPropertyName("ratingText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> RatingText { get; set; }

    [JsonPropertyName("singleRatingGraphicWidth"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue SingleRatingGraphicWidth { get; set; }

    [JsonPropertyName("singleRatingGraphic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SingleRatingGraphic { get; set; }
}