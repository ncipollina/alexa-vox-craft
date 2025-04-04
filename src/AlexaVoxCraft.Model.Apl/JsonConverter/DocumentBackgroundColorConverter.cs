using System;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class DocumentBackgroundColorConverter:JsonConverter<DocumentBackgroundColor>
{
    public override void WriteJson(JsonWriter writer, DocumentBackgroundColor value, JsonSerializer serializer)
    {
        if (value == null)
        {
            writer.WriteNull();
        }
        else if (!string.IsNullOrWhiteSpace(value.Color))
        {
            writer.WriteValue(value.Color);
        }
        else if(value.Gradient != null)
        {
            serializer.Serialize(writer,value.Gradient);
        }
    }

    public override DocumentBackgroundColor ReadJson(JsonReader reader, Type objectType, DocumentBackgroundColor existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.String)
        {
            return new DocumentBackgroundColor(reader.Value.ToString());
        }

        var gradient = serializer.Deserialize<APLGradient>(reader);
        return new DocumentBackgroundColor(gradient);
    }
}