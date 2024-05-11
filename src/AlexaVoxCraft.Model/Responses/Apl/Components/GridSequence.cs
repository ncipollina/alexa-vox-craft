using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class GridSequence : ActionableComponent
{
    [JsonPropertyName("data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<object>> Data { get; set; }

    [JsonPropertyName("firstItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> FirstItem { get; set; }

    [JsonPropertyName("lastItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> LastItem { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Items { get; set; }

    [JsonPropertyName("childHeights"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLDimensionValue>> ChildHeights { get; set; }

    [JsonPropertyName("childWidths"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLDimensionValue>> ChildWidths { get; set; }

    [JsonPropertyName("numbered"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Numbered { get; set; }

    [JsonPropertyName("onScroll"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnScroll { get; set; }

    [JsonPropertyName("scrollDirection"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<ScrollDirection?> ScrollDirection { get; set; }

    [JsonPropertyName("snap"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<Snap?> Snap { get; set; }
}