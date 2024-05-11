using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class IngredientListItem
{
    [JsonPropertyName("ingredientsContentText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> IngredientsContentText { get; set; }

    [JsonPropertyName("ingredientsPrimaryAction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> IngredientsPrimaryAction { get; set; }
}