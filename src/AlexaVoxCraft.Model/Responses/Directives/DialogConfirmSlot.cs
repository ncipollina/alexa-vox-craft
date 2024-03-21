using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class DialogConfirmSlot : Directive
{
    [JsonPropertyName("slotToConfirm"), JsonRequired]
    public string SlotName { get; set; }

    [JsonPropertyName("updatedIntent")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Intent UpdatedIntent { get; set; }
}