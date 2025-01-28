using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Unit
{
    [JsonPropertyName("unitId")]
    public required string UnitId { get; set; }

    [JsonPropertyName("persistentUnitId")]
    public required string PersistentUnitId { get; set; }
}