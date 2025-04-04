using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Extensions.EntitySensing;

public class EntitySensingSettings
{
    [JsonProperty("entitySensingStateName", NullValueHandling = NullValueHandling.Ignore)]
    public string EntitySensingStateName { get; set; }

    [JsonProperty("primaryUserName", NullValueHandling = NullValueHandling.Ignore)]
    public string PrimaryUserName { get; set; }
}