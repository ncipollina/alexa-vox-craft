using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class GenericLegacySingleOrListConverter<T> : LegacySingleOrListConverter<T>
{
    public GenericLegacySingleOrListConverter() : base() { }

    public GenericLegacySingleOrListConverter(bool alwaysOutputArray):base(alwaysOutputArray)
    {
            
    }

    protected override JsonToken SingleToken => JsonToken.StartObject;

    protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<T> list)
    {
        if (typeof(T) == typeof(object))
        {
            list.Add((T)serializer.Deserialize(reader));
        }
        else
        {
            var value = Activator.CreateInstance<T>();
            serializer.Populate(reader, value);
            list.Add(value);
        }
    }
}