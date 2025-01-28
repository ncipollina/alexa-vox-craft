using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Unit
{
    [JsonPropertyName("unitId")]
    public string? UnitId { get; set; }

    [JsonPropertyName("persistentUnitId")]
    public string? PersistentUnitId { get; set; }
}