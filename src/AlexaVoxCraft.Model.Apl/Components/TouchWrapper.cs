using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class TouchWrapper : TouchComponent
{
    public TouchWrapper()
    {

    }

    public TouchWrapper(APLComponent item)
    {
        Item = new List<APLComponent> { item };
    }

    public TouchWrapper(params APLComponent[] item) : this((IEnumerable<APLComponent>)item)
    {

    }

    public TouchWrapper(IEnumerable<APLComponent> item)
    {
        Item = new List<APLComponent>(item);
    }

    [JsonProperty("type")]
    public override string Type => nameof(TouchWrapper);


    [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLComponentListConverter))]
    public APLValue<IList<APLComponent>> Item { get; set; }
}