using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class AlexaRating:APLComponent
{
    public override string Type => nameof(AlexaRating);

    [JsonProperty("emptyRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> EmptyRatingGraphic { get; set; }

    [JsonProperty("fullRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> FullRatingGraphic { get; set; }

    [JsonProperty("halfRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> HalfRatingGraphic { get; set; }

    [JsonProperty("ratingGraphicType",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<RatingGraphicType?> RatingGraphicType { get; set; }

    [JsonProperty("ratingNumber",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<double?> RatingNumber { get; set; }

    [JsonProperty("ratingSlotMode",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<RatingSlotMode?> RatingSlotMode { get; set; }

    [JsonProperty("ratingSlotPadding",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue RatingSlotPadding { get; set; }

    [JsonProperty("ratingText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> RatingText { get; set; }

    [JsonProperty("singleRatingGraphicWidth",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue SingleRatingGraphicWidth { get; set; }

    [JsonProperty("singleRatingGraphic",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> SingleRatingGraphic { get; set; }

    [JsonProperty("ratingTextOpacity",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<double?> RatingTextOpacity { get; set; }
}