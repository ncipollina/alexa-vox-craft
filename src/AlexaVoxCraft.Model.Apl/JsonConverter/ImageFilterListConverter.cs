using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Filters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class ImageFilterListConverter : SingleOrListConverter<IImageFilter>
{
    public ImageFilterListConverter(bool alwaysOutputArray) : base(alwaysOutputArray) { }
}