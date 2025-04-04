using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class ScrollView:ActionableComponent
{
    public const string ComponentType = "ScrollView";
    public override string Type => ComponentType;

    public ScrollView() { }
    public ScrollView(APLComponent component)
    {
        Item = new List<APLComponent> {component};
    }

    public ScrollView(params APLComponent[] components) : this((IEnumerable<APLComponent>)components) { }

    public ScrollView(IEnumerable<APLComponent> components)
    {
        Item = new List<APLComponent>(components);
    }

    [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore), 
     JsonConverter(typeof(APLComponentListConverter))]
    public APLValue<IList<APLComponent>> Item { get; set; }

    [JsonProperty("onScroll", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnScroll { get; set; }
}