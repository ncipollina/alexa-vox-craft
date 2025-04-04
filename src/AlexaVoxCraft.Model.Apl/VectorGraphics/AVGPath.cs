using System.Collections.Generic;
using System.Runtime.Serialization;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.VectorGraphics;

public class AVGPath : AVGItem
{
    [JsonProperty("type")] public override string Type => "path";

    [JsonProperty("fillOpacity",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<double?> FillOpacity { get; set; }

    [JsonProperty("fill",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Fill { get; set; }

    [JsonProperty("fillTransform",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> FillTransform { get; set; }

    [JsonProperty("pathData",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> PathData { get; set; }

    [JsonProperty("pathLength",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> PathLength { get; set; }

    [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Stroke { get; set; }

    [JsonProperty("strokeDashArray",NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(GenericLegacySingleOrListConverter<APLValue<int?>>))]
    public APLValue<IList<APLValue<int?>>> StrokeDashArray { get; set; }

    [JsonProperty("strokeDashOffset",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> StrokeDashOffset { get; set; }

    [JsonProperty("strokeLineCap",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<StrokeLineCap?> StrokeLineCap { get; set; }

    [JsonProperty("strokeLineJoin", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<StrokeLineJoin?> StrokeLineJoin { get; set; }

    [JsonProperty("strokeMiterLimit",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> StrokeMiterLimit { get; set; }

    [JsonProperty("strokeOpacity",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<double?> StrokeOpacity { get; set; }
        
    [JsonProperty("strokeWidth",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> StrokeWidth { get; set; }

    [JsonProperty("strokeTransform",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> StrokeTransform { get; set; }

    [JsonProperty("style",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Style { get; set; }


}

[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<StrokeLineJoin>))]
public enum StrokeLineJoin
{
    [EnumMember(Value="bevel")]
    Bevel,
    [EnumMember(Value="miter")]
    Miter,
    [EnumMember(Value="round")]
    Round
}

[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<StrokeLineCap>))]
public enum StrokeLineCap
{
    [EnumMember(Value="butt")]
    Butt,
    [EnumMember(Value="round")]
    Round,
    [EnumMember(Value="square")]
    Square
}