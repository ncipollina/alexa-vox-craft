namespace AlexaVoxCraft.Model.Responses.Apl;

public class RelativeDimension : Dimension
{
    public int Percentage { get; set; }
    public RelativeDimension()
    {
    }

    public RelativeDimension(int percentage) => Percentage = percentage;

    public override object? GetValue() => $"{Percentage}%";
}