using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class DialogUpdateDynamicEntities : Directive
{
    [JsonPropertyName("updateBehavior"), JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<UpdateBehavior>))]
    public UpdateBehavior UpdateBehavior { get; set; }

    [JsonPropertyName("types")]
    public List<SlotType> Types { get; set; } = new List<SlotType>();
}