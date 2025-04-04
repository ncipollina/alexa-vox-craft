using System;
using System.Collections.Concurrent;
using System.Reflection;
using AlexaVoxCraft.Model.Apl.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class APLComponentConverter : Newtonsoft.Json.JsonConverter
{
    public static bool ThrowConversionExceptions { get; set; }

    public override bool CanWrite => false;

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {

    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        // Load JObject from stream
        var jObject = JObject.Load(reader);
        var componentType = jObject.Value<string>("type");
        object target = APLComponentLookup.GetLookupType<APLComponent>(componentType, "AlexaVoxCraft.Model.Apl.Components", s => new CustomComponent(s));
        if (target == null)
        {
            throw new ArgumentOutOfRangeException($"Component type {componentType} not supported");
        }

        jObject.Move("gesture", "gestures");
        jObject.Move("entity", "entities");

        if (target is GridSequence)
        {
            jObject.Move("childHeight", "childHeights");
            jObject.Move("childWidth", "childWidths");
        }

        if ((target is Frame || target is TouchWrapper) && jObject["items"] != null)
        {
            jObject.Move("items", "item");
        }

        if ((target is Container || target is Pager || target is GridSequence) && jObject["item"] != null)
        {
            jObject.Move("item", "items");
        }

        try
        {
            serializer.Populate(jObject.CreateReader(), target);
        }
        catch
        {
            if (ThrowConversionExceptions)
            {
                throw;
            }
        }

        if (target is CustomComponent custom)
        {
            custom.Properties.Remove("type");
        }

        return target;

    }

    public static ConcurrentDictionary<string, Type> APLComponentLookup = new ConcurrentDictionary<string, Type>
    {

    };

    public override bool CanConvert(Type objectType)
    {
        return objectType.GetTypeInfo().IsSubclassOf(typeof(APLComponent));
    }
}