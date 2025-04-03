﻿using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Response.Converters;

namespace AlexaVoxCraft.Model.Response;

[JsonConverter(typeof(ProgressiveResponseDirectiveConverter))]
public interface IProgressiveResponseDirective
{
    string Type { get; }
}