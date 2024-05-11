using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class DynamicIndexList : APLDataSource
{
    public DynamicIndexList()
    {
    }

    public DynamicIndexList(string listId, int startIndex = 0)
    {
        ListId = listId;
        StartIndex = startIndex;
    }

    public const string DataSourceType = "dynamicIndexList";

    [JsonPropertyName("listId")] public string ListId { get; set; }

    [JsonPropertyName("startIndex")] public int StartIndex { get; set; }

    [JsonPropertyName("minimumInclusiveIndex"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int MinimumInclusiveIndex { get; set; }

    [JsonPropertyName("maximumExclusiveIndex"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int MaximumExclusiveIndex { get; set; }

    [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<object> Items { get; set; } = new List<object>();
}