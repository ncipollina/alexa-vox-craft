using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl;

public class APLDimensionValue<T> : APLValue<T> where T : Dimension
{
    public APLDimensionValue()
    {
    }

    public APLDimensionValue(T dimension) : base(dimension)
    {
    }

    public override object? GetValue()
    {
        if (Value is null)
        {
            return null;
        }

        var value = Value.GetValue()?.ToString();
        if (value != null && value.All(char.IsDigit))
        {
            return int.Parse(value);
        }

        return value;
    }
}

[JsonConverter(typeof(APLValueConverter))]
public class APLDimensionValue : APLDimensionValue<Dimension>
{
    public APLDimensionValue()
    {
    }

    public APLDimensionValue(Dimension dimension) : base(dimension)
    {
    }

    public APLDimensionValue(string value)
    {
        var dimension = Dimension.From(value);
        if (dimension is null)
        {
            Expression = value;
        }

        Value = dimension;
    }

    public static implicit operator APLDimensionValue(int value) =>
        new APLDimensionValue(new AbsoluteDimension(value, "dp"));

    public static implicit operator APLDimensionValue(string value) => new APLDimensionValue(value);

    public static implicit operator APLDimensionValue(Dimension value) => new APLDimensionValue(value);
}