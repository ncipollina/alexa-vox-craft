using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Components;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Layout
{
    public Layout() { }

    public Layout(params APLComponent[] items) : this((IEnumerable<APLComponent>)items) { }

    public Layout(IEnumerable<APLComponent> items)
    {
        Items = items.ToList();
    }

    [JsonPropertyName("bind"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Binding> Bindings { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    [JsonPropertyName("parameters"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull),
     JsonConverter(typeof(ListObjectOrStringJsonConverter<Parameter, IList<Parameter>>))]
    public IList<Parameter>? Parameters { get; set; }
    
    [JsonPropertyName("items")]
    public IEnumerable<APLComponent> Items { get; set; }
    
    public Layout AsMain(string dataSourceKey = "payload")
    {
        Parameters ??= new List<Parameter>();

        if (!Parameters.All(p => string.Equals(p.Name, dataSourceKey, StringComparison.OrdinalIgnoreCase))) return this;
        Parameters.Add(new Parameter(dataSourceKey));

        return this;
    }
}