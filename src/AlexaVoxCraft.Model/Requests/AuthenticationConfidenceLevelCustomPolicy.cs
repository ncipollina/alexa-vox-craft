using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class AuthenticationConfidenceLevelCustomPolicy
{
    public AuthenticationConfidenceLevelCustomPolicy(){}

    public AuthenticationConfidenceLevelCustomPolicy(string policyName)
    {
        PolicyName = policyName;
    }

    [JsonPropertyName("policyName")]
    public required string PolicyName { get; set; }
}