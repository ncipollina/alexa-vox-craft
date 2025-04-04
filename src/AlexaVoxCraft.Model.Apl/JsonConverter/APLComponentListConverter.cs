using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class APLComponentListConverter: LegacySingleOrListConverter<APLComponent>
{
    public APLComponentListConverter() : this(false) { }

    public APLComponentListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

    private readonly APLComponentConverter _converter = new APLComponentConverter();
    protected override JsonToken SingleToken => JsonToken.StartObject;

    protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<APLComponent> list)
    {
        var value = (APLComponent)_converter.ReadJson(reader, typeof(APLComponent), null, serializer);
        list.Add(value);
    }
}