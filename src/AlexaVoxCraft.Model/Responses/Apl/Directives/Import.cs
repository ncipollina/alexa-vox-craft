using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class Import : IEquatable<Import>
{
    public Import()
    {
    }

    public Import(string name, string version)
    {
        Name = name;
        Version = version;
    }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Version { get; set; }

    [JsonPropertyName("source"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Source { get; set; }

    [JsonPropertyName("when"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> When { get; set; }

    [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ImportType? Type { get; set; }

    [JsonPropertyName("loadAfter"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<ConvertableString, IList<ConvertableString>>))]
    public IList<ConvertableString> LoadAfter { get; set; } = new List<ConvertableString>();

    public static Import AlexaStyles => new Import("alexa-styles", "1.6.0");
    public static Import AlexaViewportProfiles => new Import("alexa-viewport-profiles", "1.6.0");
    public static Import AlexaLayouts => new Import("alexa-layouts", "1.7.0");
    public static Import AlexaIcon => new Import("alexa-icon", "1.0.0");

    public void Into(APLDocument document)
    {

        if (document.Imports == null)
        {
            document.Imports = new List<Import>();
        }
        else if (document.Imports.Contains(this))
        {
            return;
        }

        document.Imports.Add(this);
    }

    public bool Equals(Import? other)
    {
        if (other == null)
        {
            return false;
        }

        return other.Name == Name && other.Version == Version;
    }
}