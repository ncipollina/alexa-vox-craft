﻿namespace AlexaVoxCraft.Model.Responses.Apl;

public class APLAbsoluteDimensionValue : APLDimensionValue<AbsoluteDimension>
{
    public APLAbsoluteDimensionValue()
    {
    }

    public APLAbsoluteDimensionValue(AbsoluteDimension dimension) : base(dimension)
    {
    }

    public APLAbsoluteDimensionValue(int number, string unit) : this(new AbsoluteDimension(number,unit))
    {
    }

    public APLAbsoluteDimensionValue(string value)
    {
        var dimension = Dimension.From(value);

        if (dimension == null)
        {
            Expression = value;
            return;
        }

        if (dimension.GetType() != typeof(AbsoluteDimension))
        {
            throw new InvalidOperationException($"{value} is used for {dimension.GetType().Name}, not AbsoluteDimension");
        }

        Value = dimension as AbsoluteDimension;
    }

    public static implicit operator APLAbsoluteDimensionValue(string value) => new(value);

    public static implicit operator APLAbsoluteDimensionValue(AbsoluteDimension value) => new(value);

    public static implicit operator APLAbsoluteDimensionValue(int value) => new(value,"dp");

}