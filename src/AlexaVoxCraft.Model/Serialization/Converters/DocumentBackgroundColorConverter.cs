using System.Text.Json;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class DocumentBackgroundColorConverter : JsonConverter<DocumentBackgroundColor>
{
    public override DocumentBackgroundColor? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }

        using var document = JsonDocument.ParseValue(ref reader);
        return JsonSerializer.Deserialize<APLGradient>(document.RootElement.GetRawText(), options);
    }

    public override void Write(Utf8JsonWriter writer, DocumentBackgroundColor value, JsonSerializerOptions options)
    {
        if (!string.IsNullOrWhiteSpace(value.Color))
        {
            writer.WriteStringValue(value.Color);
        }
        else if (value.Gradient is not null)
        {
            JsonSerializer.Serialize(writer, value.Gradient, options);
        }
    }
}