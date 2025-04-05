using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public class APLTDocument : APLDocumentBase
{
    public const string DocumentType = "APLT";
    [JsonPropertyName("type")]
    public override string Type => DocumentType;

    public APLTDocument():base(APLDocumentVersion.V1)
    {

    }
}