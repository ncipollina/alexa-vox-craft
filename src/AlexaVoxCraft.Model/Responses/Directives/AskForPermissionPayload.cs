using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AskForPermissionPayload
{
    [JsonPropertyName("@version"), JsonRequired] 
    public string Version { get; set; } = "1";

    [JsonPropertyName("permissionScopes"), JsonRequired]
    public IList<PermissionScope> PermissionScopes { get; set; } = new List<PermissionScope>();
}