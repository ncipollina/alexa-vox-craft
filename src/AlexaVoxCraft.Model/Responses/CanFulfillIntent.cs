using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class CanFulfillIntent
{
    [JsonPropertyName("canFulfill"),JsonRequired, JsonConverter(typeof(JsonStringEnumConverter))]
    public CanFulfill CanFulfill { get; set; }

    [JsonPropertyName("slots"), JsonRequired]
    public Dictionary<string, CanFulfillSlot> Slots { get; set; } = new();
}

public class CanFulfillSlot
{
    [JsonPropertyName("canUnderstand"), JsonConverter(typeof(JsonStringEnumConverter))]
    public CanUnderstand CanUnderstand { get; set; }
    [JsonPropertyName("canFulfill"), JsonConverter(typeof(JsonStringEnumConverter))]
    public SlotCanFulfill CanFulfill { get; set; }
}