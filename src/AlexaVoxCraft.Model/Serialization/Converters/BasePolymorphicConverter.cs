using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public abstract class BasePolymorphicConverter<T> : JsonConverter<T>
{
    public abstract string TypeDiscriminatorPropertyName { get; }
    public abstract IDictionary<string, Type> DerivedTypes { get; }
    
    public abstract Type? DefaultType { get; }
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("Invalid JSON format");
        }

        string? typeName = null;
    
        Utf8JsonReader typeReader = reader;
        while (typeReader.Read())
        {
            if (typeReader.TokenType == JsonTokenType.PropertyName && typeReader.GetString() == "type")
            {
                typeReader.Read();
                typeName = typeReader.GetString();
                break;
            }
        }

        Type resultType;
    
        if (string.IsNullOrWhiteSpace(typeName) || !DerivedTypes.TryGetValue(typeName, out resultType))
        {
            resultType = DefaultType ?? throw new JsonException($"Type {typeName} not found");
        }
        
        return (T)JsonSerializer.Deserialize(ref reader, resultType, options);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
