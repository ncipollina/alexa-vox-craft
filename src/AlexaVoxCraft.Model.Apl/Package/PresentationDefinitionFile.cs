using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Package;

public class PresentationDefinitionFile
{
    [JsonProperty("url")]
    public string Url { get; set; }
}