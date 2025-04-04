using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class ParameterConverter : JsonConverter<Parameter>
{
    public override Parameter? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString();
            return value; // uses implicit operator
        }

        // Handle object value
        if (reader.TokenType == JsonTokenType.StartObject)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;

            var parameter = new Parameter
            {
                Name = root.GetProperty("name").GetString()!,
            };

            if (root.TryGetProperty("type", out var typeProp) && typeProp.ValueKind == JsonValueKind.String)
            {
                var typeStr = typeProp.GetString();
                if (Enum.TryParse<ParameterType>(typeStr, ignoreCase: true, out var parsedType))
                {
                    parameter.Type = parsedType;
                }
            }

            if (root.TryGetProperty("description", out var descProp))
            {
                parameter.Description = descProp.GetString()!;
            }

            if (root.TryGetProperty("default", out var defaultProp))
            {
                // Use JsonElement boxing here (or enhance based on expected types)
                parameter.Default = defaultProp.Clone();
            }

            return parameter;
        }
        throw new JsonException($"Unsupported JSON token for Parameter: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, Parameter value, JsonSerializerOptions options)
    {
        if (value.WasStringInput)
        {
            writer.WriteStringValue(value.Name);
        }
        else
        {
            JsonSerializer.Serialize(writer, value, typeof(Parameter), options);
        }
    }
}