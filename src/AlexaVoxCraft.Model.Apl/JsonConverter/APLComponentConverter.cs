using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using AlexaVoxCraft.Model.Apl.Components;
using AlexaVoxCraft.Model.Response.Converters;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class APLComponentConverter :BasePolymorphicConverter<APLComponent>
{
    public static ConcurrentDictionary<string, Type> APLComponentLookup = new()
    {

    };
    protected override IDictionary<string, Type> DerivedTypes => APLComponentLookup;
    protected override JsonElement TransformJson(JsonElement original)
    {
        var obj = original.Deserialize<JsonObject>() ?? new JsonObject();

        string? type = obj["type"]?.GetValue<string>();
        if (string.IsNullOrEmpty(type))
        {
            return original;
        }

        // Universal field renames
        Move(obj, "gesture", "gestures");
        Move(obj, "entity", "entities");

        // Type-specific remapping
        switch (type)
        {
            case "GridSequence":
                Move(obj, "childHeight", "childHeights");
                Move(obj, "childWidth", "childWidths");

                if (obj.ContainsKey("item"))
                    Move(obj, "item", "items");
                break;

            case "Frame":
            case "TouchWrapper":
                if (obj.ContainsKey("items"))
                    Move(obj, "items", "item");
                break;

            case "Container":
            case "Pager":
                if (obj.ContainsKey("item"))
                    Move(obj, "item", "items");
                break;
        }

        return JsonSerializer.Deserialize<JsonElement>(obj.ToJsonString());
    }

    private static void Move(JsonObject json, string from, string to)
    {
        if (json.ContainsKey(from))
        {
            json[to] = json[from];
            json.Remove(from);
        }
    }

    public override Type? DefaultType => typeof(CustomComponent);
}