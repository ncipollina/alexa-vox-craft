using AlexaVoxCraft.Tests.Fixtures.Extensions;
using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace AlexaVoxCraft.Tests.Fixtures.Attributes;

public class ModelAutoDataAttribute(Type modelType, string filePath) : AutoDataAttribute(() =>
{
    var fixture = new Fixture();
    fixture.Customize(new CompositeCustomization(new AutoNSubstituteCustomization()))
        .AddModel(modelType, filePath);
    fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
        .ForEach(b => fixture.Behaviors.Remove(b));
    fixture.Behaviors.Add(new OmitOnRecursionBehavior());
    return fixture;
});

public class InlineModelAutoDataAttribute(Type modelType, string filePath, params object[] arguments)
    : InlineAutoDataAttribute(new ModelAutoDataAttribute(modelType, filePath), arguments)
{
}