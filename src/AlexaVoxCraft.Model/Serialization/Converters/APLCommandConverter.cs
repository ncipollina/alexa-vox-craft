using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLCommandConverter : BasePolymorphicConverter<APLCommand>
{
    public override string TypeDiscriminatorPropertyName => "type";

    public override IDictionary<string, Type> DerivedTypes => new Dictionary<string, Type>
    {
        { nameof(AutoPage), typeof(AutoPage) },
        { nameof(SetValue), typeof(SetValue) },
        { nameof(SendEvent), typeof(SendEvent) },
        { nameof(SetPage), typeof(SetPage) },
        { nameof(SpeakItem), typeof(SpeakItem) }
    };

    public override Type? DefaultType => typeof(CustomCommand);
}