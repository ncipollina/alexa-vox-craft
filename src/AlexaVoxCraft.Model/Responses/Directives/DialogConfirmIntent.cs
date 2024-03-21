using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class DialogConfirmIntent : Directive
{
    [JsonPropertyName("updatedIntent")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Intent UpdatedIntent { get; set; }
}