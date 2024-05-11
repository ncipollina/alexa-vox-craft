using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class ScrollView : ActionableComponent
{
    [JsonPropertyName("item"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Item { get; set; }
    
    [JsonPropertyName("onScroll"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnScroll { get; set; }
}