namespace AlexaVoxCraft.Model.Serialization.Converters;

public class ConvertableString(string? internalString = null) : IStringConvertable<ConvertableString>
{
    public static ConvertableString FromString(string value) => value;

    public static implicit operator ConvertableString(string stringValue) => new(stringValue);

    public bool ShouldSerializeAsString() => true;

    public override string? ToString() => internalString;
}