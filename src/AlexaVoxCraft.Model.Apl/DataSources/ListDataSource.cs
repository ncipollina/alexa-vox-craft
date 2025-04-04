using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataSources;

public class ListDataSource : APLDataSource
{
    public const string DataSourceType = "list";
    public override string Type => DataSourceType;

    [JsonProperty("listPage")]
    public ListPage ListPage { get; }

    [JsonProperty("listId")]
    public string ListId { get; set; }

    [JsonProperty("totalNumberOfItems")]
    public int TotalNumberOfItems { get; set; }

    public ListDataSource()
    {
        ListPage = new ListPage();
    }
}