using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Filters;

public class Blur:IImageFilter
{
    [JsonProperty("radius",NullValueHandling = NullValueHandling.Ignore)]
    public APLDimensionValue Radius { get; set; }
    public Blur() { }

    public Blur(Dimension radius)
    {
        Radius = radius;
    }

    public string Type => nameof(Blur);
}