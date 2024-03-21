using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class ListDataSource : APLDataSource
{
    public const string DataSourceType = "list";

    [JsonPropertyName("listPage")]
    public ListPage ListPage { get; }

    [JsonPropertyName("listId")]
    public string ListId { get; set; }

    [JsonPropertyName("totalNumberOfItems")]
    public int TotalNumberOfItems { get; set; }

    public ListDataSource()
    {
        ListPage = new ListPage();
    }
}