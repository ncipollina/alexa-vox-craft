using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Filters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class ImageFilterListConverter : LegacySingleOrListConverter<IImageFilter>
{
    public ImageFilterListConverter() : this(false) { }

    public ImageFilterListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }

    private readonly ImageFilterConverter _converter = new ImageFilterConverter();
    protected override JsonToken SingleToken => JsonToken.StartObject;

    protected override void ReadSingle(JsonReader reader, JsonSerializer serializer, List<IImageFilter> list)
    {
        var value = (IImageFilter)_converter.ReadJson(reader, typeof(IImageFilter), null, serializer);
        list.Add(value);
    }
}