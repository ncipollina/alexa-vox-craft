using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class UnknownDocumentVersionConverter:StringEnumConverter
{
    public UnknownDocumentVersionConverter()
    {

    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        try
        {
            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
        catch (JsonSerializationException)
        {
            return APLDocumentVersion.Unknown;
        }
    }
}