using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public abstract class ViewPort
{
    [JsonPropertyName("id")]
    public virtual string Id { get; set; }
}