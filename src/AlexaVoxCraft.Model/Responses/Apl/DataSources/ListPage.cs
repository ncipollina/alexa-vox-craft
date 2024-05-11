using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class ListPage
{
    public ListPage()
    {
        ListItems = new List<object>();
    }

    [JsonPropertyName("listItems")]
    public List<object> ListItems { get; set; }
}