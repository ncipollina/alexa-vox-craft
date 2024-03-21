using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

[JsonConverter(typeof(APLComponentConverter))]
public abstract class APLComponent : APLComponentBase
{
    [JsonPropertyName("inheritParentState"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> InheritParentState { get; set; }

    [JsonPropertyName("style"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Style { get; set; }

    [JsonPropertyName("padding"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<int>> Padding { get; set; }

    [JsonPropertyName("paddingStart"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingStart { get; set; }

    [JsonPropertyName("paddingEnd"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingEnd { get; set; }

    [JsonPropertyName("paddingLeft"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingLeft { get; set; }

    [JsonPropertyName("paddingTop"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingTop { get; set; }

    [JsonPropertyName("paddingRight"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingRight { get; set; }

    [JsonPropertyName("paddingBottom"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue PaddingBottom { get; set; }

    [JsonPropertyName("minWidth"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue MinWidth { get; set; }

    [JsonPropertyName("minHeight"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue MinHeight { get; set; }

    [JsonPropertyName("maxWidth"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue MaxWidth { get; set; }

    [JsonPropertyName("maxHeight"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue MaxHeight { get; set; }

    [JsonPropertyName("height"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Height { get; set; }

    [JsonPropertyName("width"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Width { get; set; }

    [JsonPropertyName("alignSelf"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> AlignSelf { get; set; }

    [JsonPropertyName("bottom"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Bottom { get; set; }

    [JsonPropertyName("grow"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> Grow { get; set; }

    [JsonPropertyName("left"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Left { get; set; }

    [JsonPropertyName("start"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Start { get; set; }

    [JsonPropertyName("numbering"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Numbering { get; set; }

    [JsonPropertyName("position"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Position { get; set; }

    [JsonPropertyName("right"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Right { get; set; }

    [JsonPropertyName("end"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue End { get; set; }

    [JsonPropertyName("shrink"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Shrink { get; set; }

    [JsonPropertyName("spacing"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Spacing { get; set; }

    [JsonPropertyName("top"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDimensionValue Top { get; set; }

    [JsonPropertyName("speech"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Speech { get; set; }

    [JsonExtensionData] public Dictionary<string, object> Properties { get; set; }

    [JsonPropertyName("accessibilityLabel"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> AccessibilityLabel { get; set; }

    [JsonPropertyName("checked"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> Checked { get; set; }

    [JsonPropertyName("disabled"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> Disabled { get; set; }

    [JsonPropertyName("display"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<APLDisplay> Display { get; set; }

    [JsonPropertyName("onMount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnMount { get; set; }

    [JsonPropertyName("onCursorEnter"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnCursorEnter { get; set; }

    [JsonPropertyName("onCursorExit"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnCursorExit { get; set; }

    [JsonPropertyName("onSpeechMark"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnSpeechMark { get; set; }

    [JsonPropertyName("transform"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLTransform>> Transform { get; set; }

    [JsonPropertyName("shadowColor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ShadowColor { get; set; }

    [JsonPropertyName("shadowHorizontalOffset"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLAbsoluteDimensionValue ShadowHorizontalOffset { get; set; }

    [JsonPropertyName("shadowVerticalOffset"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLAbsoluteDimensionValue ShadowVerticalOffset { get; set; }

    [JsonPropertyName("shadowRadius"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLAbsoluteDimensionValue ShadowRadius { get; set; }

    [JsonPropertyName("opacity"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> Opacity { get; set; }

    [JsonPropertyName("entities"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<object>> Entities { get; set; }

    [JsonPropertyName("handleTick"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<TickHandler>> HandleTick { get; set; }

    [JsonPropertyName("role"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Role { get; set; }

    [JsonPropertyName("actions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLAction>> Actions { get; set; }

    [JsonPropertyName("preserve"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<string>> Preserve { get; set; }

    [JsonPropertyName("layoutDirection"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<LayoutDirection?> LayoutDirection { get; set; }
}