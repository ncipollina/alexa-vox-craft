namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class GenericSingleOrListConverter<TValue> : SingleOrListConverter<TValue>
{
    public GenericSingleOrListConverter(bool alwaysOutputArray = false) : base(alwaysOutputArray)
    {
    }
}