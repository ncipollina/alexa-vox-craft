using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class Sequence : ActionableComponent
{
    public Sequence()
    {
    }

    public Sequence(params APLComponent[] items) : this((IEnumerable<APLComponent>)items)
    {
    }

    public Sequence(IEnumerable<APLComponent> items)
    {
        Items = items.ToList();
    }
    
    [JsonPropertyName("data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<List<object>> Data { get; set; }

    [JsonPropertyName("scrollDirection"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ScrollDirection { get; set; }

    [JsonPropertyName("firstItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<List<APLComponent>> FirstItem { get; set; }

    [JsonPropertyName("lastItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<List<APLComponent>> LastItem { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<List<APLComponent>> Items { get; set; }

    [JsonPropertyName("numbered"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> Numbered { get; set; }

    [JsonPropertyName("onScroll"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLCommand>> OnScroll { get; set; }

    [JsonPropertyName("scaling"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Scaling { get; set; }

    [JsonPropertyName("snap"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<Snap?> Snap { get; set; }
}