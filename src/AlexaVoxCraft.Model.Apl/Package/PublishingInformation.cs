using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Package;

public class PublishingInformation
{
    [JsonProperty("schemaVersion")] public string SchemaVersion { get; set; } = "1.0";

    [JsonProperty("locales")] public Dictionary<string, List<LocalePublishingInformation>> Locales { get; set; } = new();
}