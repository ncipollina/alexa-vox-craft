using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;

public class DataStoreSettings
{
    [JsonPropertyName("dataBindings")] public IList<DataBinding> DataBindings { get; set; } = new List<DataBinding>();
}