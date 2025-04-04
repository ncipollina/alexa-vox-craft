using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class RemoveNamespace : DataStoreCommand
{
    public const string CommandType = "REMOVE_NAMESPACE";

    public RemoveNamespace():base(CommandType){}

    [JsonProperty("namespace")]
    public string Namespace { get; set; }
}