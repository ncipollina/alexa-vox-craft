using System.Text.Json;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Components;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLComponentListConverter : SingleOrListConverter<APLComponent, IEnumerable<APLComponent>>
{
}

public abstract class SingleOrListConverter<TValue, TList> : JsonConverter<TList> where TList : IEnumerable<TValue>
{
    public bool AlwaysOutputArray { get; }

    protected SingleOrListConverter() : this(false)
    {
    }

    protected SingleOrListConverter(bool alwaysOutputArray)
    {
        AlwaysOutputArray = alwaysOutputArray;
    }

    public override TList? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        var list = new List<TValue>();

        switch (root)
        {
            case { ValueKind: JsonValueKind.Object }:
                list.Add(JsonSerializer.Deserialize<TValue>(root.GetRawText(), options));
                break;
            case { ValueKind: JsonValueKind.Array }:
            {
                list.AddRange(root.EnumerateArray().Select(element => JsonSerializer.Deserialize<TValue>(element.GetRawText(), options)));

                break;
            }
            default:
                throw new JsonException("Expected JSON array, string, or object.");
        }

        return (TList)list.AsEnumerable();
    }

    public override void Write(Utf8JsonWriter writer, TList value, JsonSerializerOptions options)
    {
        if (!AlwaysOutputArray)
        {
            if (value.Count() == 1)
            {
                var item = value.First();
                JsonSerializer.Serialize(writer, item, options);
                return;
            }
        }
        JsonSerializer.Serialize(writer, value, options);
    }
}