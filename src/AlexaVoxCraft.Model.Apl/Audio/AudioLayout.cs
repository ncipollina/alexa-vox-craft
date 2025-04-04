using System;
using System.Collections.Generic;
using System.Linq;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio;

public class AudioLayout
{
    public AudioLayout() { }

    public AudioLayout(params APLAComponent[] items) : this((IEnumerable<APLAComponent>)items) { }

    public AudioLayout(IEnumerable<APLAComponent> items)
    {
        Items = items.ToList();
    }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(ParameterListConverter), true)]
    public IList<Parameter> Parameters { get; set; }

    [JsonProperty("items"),
     JsonConverter(typeof(APLAComponentListConverter), true)]
    public IList<APLAComponent> Items { get; set; }

    public AudioLayout AsMain(string dataSourceKey = "payload")
    {
        if (Parameters == null)
        {
            Parameters = new List<Parameter>();
        }

        if (Parameters.All(p => string.Equals(p.Name, dataSourceKey, StringComparison.OrdinalIgnoreCase)))
        {
            Parameters.Add(new Parameter(dataSourceKey));
        }

        return this;
    }
}