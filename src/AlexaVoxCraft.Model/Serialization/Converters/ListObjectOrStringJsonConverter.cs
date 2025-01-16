using System.Text.Json;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class ParameterListConverter : ListObjectOrStringJsonConverter<Parameter, IList<Parameter>>
{
    public ParameterListConverter() : base(true)
    {
    }
}

public class ListObjectOrStringJsonConverter<TValue, TList> : JsonConverter<TList> where TList : IEnumerable<TValue>
    where TValue : IStringConvertable<TValue>
{
    public ListObjectOrStringJsonConverter() : this(false)
    {
    }

    public ListObjectOrStringJsonConverter(bool alwaysOutputArray = false)
    {
        AlwaysOutputArray = alwaysOutputArray;
    }
    
    public bool AlwaysOutputArray { get; }
    public override TList? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        var list = new List<TValue>();

        if (root.ValueKind == JsonValueKind.Object)
        {
            list.Add(JsonSerializer.Deserialize<TValue>(root.GetRawText(), options));
        }
        else if (root.ValueKind == JsonValueKind.String)
        {
            list.Add(TValue.FromString(root.GetString()));
        }
        else if (root.ValueKind == JsonValueKind.Array)
        {
            foreach (var element in root.EnumerateArray())
            {
                if (element.ValueKind == JsonValueKind.String)
                {
                    list.Add(TValue.FromString(element.GetString()));
                }
                else
                {
                    list.Add(JsonSerializer.Deserialize<TValue>(element.GetRawText(), options));
                }
            }
        }
        else
        {
            throw new JsonException("Expected JSON array, string, or object.");
        }

        return (TList)list.AsEnumerable();
    }

    public override void Write(Utf8JsonWriter writer, TList value, JsonSerializerOptions options)
    {
        if (value is null || !value.Any())
        {
            writer.WriteNullValue();
            return;
        }
        if (value.Count() == 1 && !AlwaysOutputArray)
        {
            var item = value.First();
            if (item.ShouldSerializeAsString())
            {
                JsonSerializer.Serialize(writer, item.ToString(), options);
            }
            else
            {
                JsonSerializer.Serialize(writer, item, options);
            }
        } else
        {
            writer.WriteStartArray();
            foreach (var item in value)
            {
                if (item.ShouldSerializeAsString())
                {
                    writer.WriteStringValue(item.ToString());
                }
                else
                {
                    JsonSerializer.Serialize(writer, item, options);
                }
            }

            writer.WriteEndArray();
        }
    }
}

public interface IStringConvertable<out T> where T : IStringConvertable<T>
{
    static abstract T FromString(string value);

    bool ShouldSerializeAsString();
}