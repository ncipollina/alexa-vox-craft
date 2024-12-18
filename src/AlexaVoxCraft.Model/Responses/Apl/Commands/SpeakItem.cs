﻿using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class SpeakItem : APLCommand
{
    [JsonPropertyName("align"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ItemAlignment>))]
    public APLValue<ItemAlignment?> Align { get; set; }

    [JsonPropertyName("componentId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ComponentId { get; set; }

    [JsonPropertyName("highlightMode"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<HighlightMode>))]
    public APLValue<HighlightMode?> HighlightMode { get; set; }
}