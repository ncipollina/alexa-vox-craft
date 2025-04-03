using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Response.Converters;

public abstract class BasePolymorphicConverter<T> : JsonConverter<T>
{
    protected abstract string TypeDiscriminatorPropertyName { get; }
    protected abstract IDictionary<string, Type> DerivedTypes { get; }
    protected abstract IDictionary<string, Func<JsonElement, Type>> DataDrivenTypeFactories { get; }

    protected virtual Func<JsonElement, string?> KeyResolver => element =>
    {
        var typeValue = element.TryGetProperty(TypeDiscriminatorPropertyName, out var typeProp)
            ? typeProp.GetString()
            : null;
        return typeValue;
    };
    
    protected abstract Func<JsonElement, Type?>? CustomTypeResolver { get; }

    public abstract Type? DefaultType { get; }

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        Type? resultType = null;
        var typeValue = KeyResolver(root);

        if (string.IsNullOrWhiteSpace(typeValue) && CustomTypeResolver is not null)
        {
            resultType = CustomTypeResolver(root);
        }
        else
        {
            if (string.IsNullOrWhiteSpace(typeValue))
                throw new JsonException("Missing 'type' field");

            resultType = DefaultType;

            if (DerivedTypes.TryGetValue(typeValue, out var type))
            {
                resultType = type;
            }
            else if (DataDrivenTypeFactories.TryGetValue(typeValue, out var dataFactory))
            {
                resultType = dataFactory(root);
            }
        }

        return resultType is not null
            ? (T)JsonSerializer.Deserialize(root.GetRawText(), resultType, options)!
            : throw new JsonException($"Unrecognized type '{typeValue}'");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
