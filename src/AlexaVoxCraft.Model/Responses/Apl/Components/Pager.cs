using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class Pager : ActionableComponent
{
    public Pager()
    {
    }

    public Pager(params APLComponent[] items) : this((IEnumerable<APLComponent>)items)
    {
    }

    public Pager(IEnumerable<APLComponent> items)
    {
        Items = items.ToList();
    }


    [JsonPropertyName("data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<object>> Data { get; set; }

    [JsonPropertyName("firstItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> FirstItem { get; set; }

    [JsonPropertyName("lastItem"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> LastItem { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Items { get; set; }

    [JsonPropertyName("initialPage"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> InitialPage { get; set; }

    [JsonPropertyName("navigation"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Navigation { get; set; }

    [JsonPropertyName("onPageChanged"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnPageChanged { get; set; }

    [JsonPropertyName("handlePageMove"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLPageMoveHandler>> HandlePageMove { get; set; }

    [JsonPropertyName("onChildrenChanged"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnChildrenChanged { get; set; }
}