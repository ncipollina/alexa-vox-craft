using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Unit
{
    [JsonPropertyName("unitId")]
    public string UnitID { get; set; }

    [JsonPropertyName("persistentUnitId")]
    public string PersistentUnitID { get; set; }
}