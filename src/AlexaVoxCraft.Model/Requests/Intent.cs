using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Intent
{
    private string _name = string.Empty;
    
    [JsonPropertyName("name")]
    public required string Name {
        get => _name;
        // ReSharper disable once PropertyCanBeMadeInitOnly.Global
        set {
            _name = value;
            Signature = value;
        }
    }

    [JsonIgnore]
    public IntentSignature? Signature { get; private set; }

    [JsonPropertyName("confirmationStatus")]
    public string? ConfirmationStatus { get; set; }

    [JsonPropertyName("slots")]
    public Dictionary<string, Slot>? Slots { get; set; }
}