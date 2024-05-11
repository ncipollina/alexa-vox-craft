using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLDocumentSettings
{
    public APLDocumentSettings()
    {
    }

    public APLDocumentSettings(int idleTimeout)
    {
        IdleTimeout = idleTimeout;
    }

    [JsonPropertyName("idleTimeout"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? IdleTimeout { get; set; }

    [JsonPropertyName("supportsResizing"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? SupportsResizing { get; set; }

    [JsonExtensionData] public Dictionary<string, object>? OtherSettings { get; set; }

    public void Add(string name, object settings)
    {
        OtherSettings ??= new Dictionary<string, object>();

        OtherSettings.Add(name, settings);
    }
}