using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class DynamicTokenList : APLDataSource
{
    public const string DataSourceType = "dynamicTokenList";

    [JsonPropertyName("listId")] public string ListId { get; set; }

    [JsonPropertyName("pageToken")] public string PageToken { get; set; }

    [JsonPropertyName("backwardPageToken"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string BackwardPageToken { get; set; }

    [JsonPropertyName("forwardPageToken"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ForwardPageToken { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<object> Items { get; set; } = new List<object>();
}