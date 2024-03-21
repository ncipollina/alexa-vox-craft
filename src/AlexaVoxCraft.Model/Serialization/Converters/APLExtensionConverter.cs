using AlexaVoxCraft.Model.Responses.Apl.Extensions;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.Backstack;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLExtensionConverter : BasePolymorphicConverter<APLExtension>
{
    public override string TypeDiscriminatorPropertyName => "uri";

    public override IDictionary<string, Type> DerivedTypes => new Dictionary<string, Type>
    {
        { BackstackExtension.URL, typeof(BackstackExtension) },
        { SmartMotionExtension.URL, typeof(SmartMotionExtension) },
        { DataStoreExtension.URL, typeof(DataStoreExtension) },
        { SmartMotionExtension.URL, typeof(SmartMotionExtension) }
    };
    public override Type? DefaultType => null;
}