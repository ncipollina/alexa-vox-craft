using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Export : IStringConvertable<Export>
{
    private readonly bool _fromString;
    
    public Export()
    {
    }

    public Export(string name) => (Name, _fromString) = (name, true);

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    public static implicit operator Export(string exportName) => new(exportName);

    public static Export FromString(string value) => value;

    public bool ShouldSerializeAsString() => _fromString;

    public override string ToString() => Name;
}