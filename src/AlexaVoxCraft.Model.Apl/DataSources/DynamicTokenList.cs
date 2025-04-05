using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Model.Apl.DataSources;

public class DynamicTokenList : APLDataSource
{
    public const string DataSourceType = "dynamicTokenList";
    public override string Type => DataSourceType;

    [JsonPropertyName("listId")]
    public string ListId { get; set; }

    [JsonPropertyName("pageToken")]
    public string PageToken { get; set; }

    [JsonPropertyName("backwardPageToken")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? BackwardPageToken { get; set; }

    [JsonPropertyName("forwardPageToken")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? ForwardPageToken { get; set; }

    [JsonPropertyName("items")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<object>? Items { get; set; } = new List<object>();
    public static void AddSupport()
    {
        AlexaJsonOptions.RegisterTypeModifier<DynamicTokenList>(info =>
        {
            var prop = info.Properties.FirstOrDefault(p => p.Name == "items");
            if (prop is not null)
            {
                prop.ShouldSerialize = (obj, _) =>
                {
                    var dynamicIndexList = (DynamicTokenList)obj;
                    return dynamicIndexList.Items?.Any() ?? false;
                };
            }
        });
    }
}