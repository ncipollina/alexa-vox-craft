using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class Frame : APLComponent
{
    public Frame()
    {
    }

    public Frame(APLComponent item)
    {
        Item = new List<APLComponent> { item };
    }

    public Frame(params APLComponent[] item) : this((IEnumerable<APLComponent>)item)
    {
    }

    public Frame(IEnumerable<APLComponent> item)
    {
        Item = new List<APLComponent>(item);
    }

    [JsonPropertyName("background"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<APLGradient> Background { get; set; }

    [JsonPropertyName("backgroundColor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> BackgroundColor { get; set; }

    [JsonPropertyName("borderBottomLeftRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderBottomLeftRadius { get; set; }

    [JsonPropertyName("borderBottomRightRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderBottomRightRadius { get; set; }

    [JsonPropertyName("borderColor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> BorderColor { get; set; }

    [JsonPropertyName("borderRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderRadius { get; set; }

    [JsonPropertyName("borderTopLeftRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderTopLeftRadius { get; set; }

    [JsonPropertyName("borderTopRightRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue BorderTopRightRadius { get; set; }

    [JsonPropertyName("borderWidth"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> BorderWidth { get; set; }

    [JsonPropertyName("item"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Item { get; set; }

    [JsonPropertyName("borderStrokeWidth"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLAbsoluteDimensionValue BorderStrokeWidth { get; set; }
}