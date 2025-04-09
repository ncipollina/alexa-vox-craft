using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Request.Type;

namespace AlexaVoxCraft.Model.Tests;

public class NewIntentRequest : Request.Type.Request
{
    [JsonPropertyName("testProperty")]
    public bool TestProperty { get; set; }
}