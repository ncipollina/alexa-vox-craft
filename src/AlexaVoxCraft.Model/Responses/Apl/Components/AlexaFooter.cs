using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaFooter : APLComponent
{
    public AlexaFooter()
    {
    }

    public AlexaFooter(string hintText) : this()
    {
        HintText = hintText;
    }

    [JsonPropertyName("theme"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Theme { get; set; }

    [JsonPropertyName("hintText"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> HintText { get; set; }


    [JsonPropertyName("lang"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Lang { get; set; }

}