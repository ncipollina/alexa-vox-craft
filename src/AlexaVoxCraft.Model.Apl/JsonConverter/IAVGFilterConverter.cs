using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AlexaVoxCraft.Model.Apl.VectorGraphics.Filters;
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class IAVGFilterConverter : BasePolymorphicConverter<IAVGFilter>
{
    private static readonly ConcurrentDictionary<string, Type> IavgFilterLookup = new()
    {
        [nameof(DropShadow)] = typeof(DropShadow),
    };
    protected override IDictionary<string, Type> DerivedTypes => IavgFilterLookup;
}