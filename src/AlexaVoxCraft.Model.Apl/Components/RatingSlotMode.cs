﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Response.Converters;

namespace AlexaVoxCraft.Model.Apl.Components;

[JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<RatingSlotMode>))]
public enum RatingSlotMode
{
    [EnumMember(Value="single")]
    Single,
    [EnumMember(Value = "multiple")]
    Multiple
}