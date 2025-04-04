using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class IngredientListItem
{
    [JsonProperty("ingredientsContentText",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> IngredientsContentText { get; set; }

    [JsonProperty("ingredientsPrimaryAction",NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> IngredientsPrimaryAction { get; set; }
}