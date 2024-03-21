using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;

public class GetObjectCommand : APLCommand
{
    private readonly string _extensionName;

    public static GetObjectCommand For(DataStoreExtension extension)
    {
        return new GetObjectCommand(extension.Name);
    }

    public static GetObjectCommand For(DataStoreExtension extension, string @namespace, string key, string token = null)
    {
        return new GetObjectCommand(extension.Name, @namespace, key, token);
    }

    public GetObjectCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    public GetObjectCommand(string extensionName, string @namespace, string key, string token = null) : this(
        extensionName)
    {
        Namespace = @namespace;
        Key = key;
        Token = token;
    }

    [JsonPropertyName("namespace")] public string Namespace { get; set; }

    [JsonPropertyName("key")] public string Key { get; set; }

    [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:GetObject";
}