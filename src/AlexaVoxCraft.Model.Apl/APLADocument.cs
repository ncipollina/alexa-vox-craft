using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Audio;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLADocument:APLDocumentReference
{
    public APLADocument()
    {
        VersionString = "0.8";
    }
    public override string Type => "APLA";

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Description { get; set; }

    [JsonIgnore]
    public APLADocumentVersion Version
    {
        get => EnumParser.ToEnum(VersionString, APLADocumentVersion.Unknown);
        set => VersionString = EnumParser.ToEnumString(typeof(APLADocumentVersion), value);
    }

    [JsonProperty("mainTemplate")]
    public AudioLayout MainTemplate { get; set; }

    [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
    public IList<APLAResource> Resources { get; set; }

    [JsonProperty("compositions", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, AudioLayout> Compositions { get; set; }
}