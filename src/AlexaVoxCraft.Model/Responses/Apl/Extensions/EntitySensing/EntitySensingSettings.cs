using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.EntitySensing;

public class EntitySensingSettings
{
    [JsonPropertyName("entitySensingStateName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string EntitySensingStateName { get; set; }

    [JsonPropertyName("primaryUserName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string PrimaryUserName { get; set; }
}