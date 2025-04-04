using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Commands;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class AnimatedPropertyListConverter : LegacySingleOrListConverter<AnimatedProperty>
{
    private readonly AnimatedPropertyConverter _converter = new AnimatedPropertyConverter();
    protected override JsonToken SingleToken => JsonToken.StartObject;
    protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<AnimatedProperty> list)
    {
        var value = (AnimatedProperty)_converter.ReadJson(reader, typeof(AnimatedProperty), null, serializer);
        list.Add(value);
    }
}