namespace AlexaVoxCraft.Model.Responses.Apl;

public class SpecialDimension : Dimension
{
    public string Value { get; set; }
    public SpecialDimension(string value) => Value = value;

    public override object? GetValue() => Value;
}