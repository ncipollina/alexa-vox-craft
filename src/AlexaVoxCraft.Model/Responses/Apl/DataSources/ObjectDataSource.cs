using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

public class ObjectDataSource : APLDataSource
{
    public const string DataSourceType = "object";

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    [JsonPropertyName("objectID"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ObjectId { get; set; }

    [JsonPropertyName("title"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Title { get; set; }

    [JsonPropertyName("properties")] public virtual Dictionary<string, object> Properties { get; set; }

    [JsonExtensionData] public virtual Dictionary<string, object> TopLevelData { get; set; }

    [JsonPropertyName("transformers"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<APLTransformer> Transformers { get; set; }
}