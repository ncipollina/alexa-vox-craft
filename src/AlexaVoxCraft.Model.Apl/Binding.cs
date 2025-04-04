﻿using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class Binding
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    [JsonProperty("type")]
    public ParameterType Type { get; set; } = ParameterType.any;

    [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Commands { get; set; }

    public bool ShouldSerializeType()
    {
        return Type != ParameterType.any;
    }

    [JsonConstructor]
    private Binding(){}

    public Binding(string name, string value)
    {
        Name = name;
        Value = value;
    }
}