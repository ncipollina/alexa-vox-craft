using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Responses.Apl.Components;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLDocument : APLDocumentBase
{
    public const string DocumentType = "APL";

    public APLDocument()
    {
    }

    public APLDocument(APLDocumentVersion version) : base(version)
    {
    }

    [JsonPropertyName("handleKeyDown"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLKeyboardHandler>> HandleKeyDown { get; set; }

    [JsonPropertyName("handleKeyUp"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLKeyboardHandler>> HandleKeyUp { get; set; }

    [JsonPropertyName("theme"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ViewportTheme? Theme { get; set; }

    [JsonPropertyName("import"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<Import> Imports { get; set; }
    
    [JsonPropertyName("styles"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, Style> Styles { get; set; }

    [JsonPropertyName("background"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<DocumentBackgroundColor> Background { get; set; }

    [JsonPropertyName("export"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ExportList Export { get; set; }
    
    [JsonPropertyName("onDisplayStateChange"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLCommand>> OnDisplayStateChange { get; set; }
}