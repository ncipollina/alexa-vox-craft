using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Request.Type;

namespace AlexaVoxCraft.Tests;

public class NewIntentRequest : Request
{
    [JsonPropertyName("testProperty")]
    public bool TestProperty { get; set; }
}