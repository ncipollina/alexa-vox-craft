using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Responses.Apl.Extensions;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public abstract class APLDocumentBase : APLDocumentReference
{
    protected APLDocumentBase()
    {
        Version = APLDocumentVersion.V1;
    }

    protected APLDocumentBase(APLDocumentVersion version)
    {
        Version = version;
    }

    [JsonIgnore]
    public APLDocumentVersion Version
    {
        get => VersionString.ToEnum();
        set => VersionString = value.ToEnumString();
    }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Description { get; set; }

    [JsonPropertyName("layouts"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, Layout> Layouts { get; set; }

    [JsonPropertyName("resources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Resource> Resources { get; set; }

    [JsonPropertyName("mainTemplate")] public Layout MainTemplate { get; set; }

    [JsonPropertyName("onMount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnMount { get; set; }

    [JsonPropertyName("onConfigChange"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnConfigChange { get; set; }

    [JsonPropertyName("settings"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDocumentSettings Settings { get; set; }

    [JsonPropertyName("extensions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLExtension>> Extensions = new List<APLExtension>();

    [JsonPropertyName("environment"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLDocumentEnvironment Environment { get; set; }
    
    [JsonExtensionData] public Dictionary<string, object> Handlers { get; set; }

    public void AddHandler(string name, APLValue<IList<APLCommand>>? commands)
    {
        Handlers ??= new Dictionary<string, object>();
        Handlers.Add(name, commands);
    }
}