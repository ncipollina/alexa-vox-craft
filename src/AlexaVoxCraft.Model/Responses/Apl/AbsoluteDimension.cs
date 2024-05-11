namespace AlexaVoxCraft.Model.Responses.Apl;

public class AbsoluteDimension : Dimension
{
    public string Unit { get; set; }
    
    public int Number { get; set; }

    public AbsoluteDimension(int number, string unit) => (Number, Unit) = (number, unit);

    public static explicit operator AbsoluteDimension(int value) => new AbsoluteDimension(value, string.Empty);

    public override object? GetValue() => $"{Number}{Unit}";
}