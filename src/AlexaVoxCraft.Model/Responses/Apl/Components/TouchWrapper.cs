using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

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


    [JsonPropertyName("item"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Item { get; set; }
}