using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl;

public class APLValue
{
    public string Expression { get; set; }

    public virtual bool IsSingle { get; set; } = false;

    public virtual object? GetValue()
    {
        return null;
    }

    private static Type[] _invalidValues =
    [
        typeof(AbsoluteDimension),
        typeof(Dimension),
        typeof(RelativeDimension),
        typeof(SpecialDimension),
        typeof(APLDimensionValue), 
        typeof(APLAbsoluteDimensionValue)
    ];

    public static APLValue<T> To<T>(string expression)
    {
        if (_invalidValues.Contains(typeof(T)))
        {
            throw new InvalidOperationException("Unable to use APLValue.To with Dimensions, please use new APLAbsoluteDimensionValue(string value) or new APLDimensionValue(string value) as appropriate");
        }

        return new APLValue<T> { Expression = expression };
    }
}

[JsonConverter(typeof(APLValueConverter))]
public class APLValue<T> : APLValue
{
    public APLValue()
    {
    }

    public APLValue(T value) => Value = value;
    
    public T? Value { get; set; }

    public static implicit operator T?(APLValue<T?> value) => value.Value;

    public static implicit operator APLValue<T>?(T value) => value == null ? null : new APLValue<T>(value);

    public override object? GetValue() => Value;
}