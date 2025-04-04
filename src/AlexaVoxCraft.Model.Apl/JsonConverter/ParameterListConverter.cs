namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class ParameterListConverter : GenericLegacySingleOrListConverter<Parameter>
{
    public ParameterListConverter() : base() { }

    public ParameterListConverter(bool alwaysArray) : base(alwaysArray) { }
    protected override object OutputArrayItem(Parameter param)
    {
        if (param.Default == null && string.IsNullOrWhiteSpace(param.Description) &&
            param.ShouldSerializeType() == false)
        {
            return param.Name;
        }

        return param;
    }
}