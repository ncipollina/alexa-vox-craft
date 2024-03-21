using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class PermissionScope
{
    [JsonPropertyName("permissionScope")]
    [JsonRequired]
    public string Scope { get; set; }

    [JsonPropertyName("consentLevel"), JsonRequired,
     JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ConsentLevel>))]
    public ConsentLevel ConsentLevel { get; set; }
}