using AlexaVoxCraft.Tests.Fixtures.SpecimenBuilders;
using AutoFixture;

namespace AlexaVoxCraft.Tests.Fixtures.Extensions;

public static class FixtureExtensions
{
    public static IFixture AddModel(this IFixture fixture, Type modelType, params string[] fileName)
    {
        var methodInfo = typeof(FixtureExtensions)
            .GetMethods().Single(method => method is { Name: nameof(AddModel), IsGenericMethod: true });
        var methodInfoGeneric = methodInfo.MakeGenericMethod(modelType);
        methodInfoGeneric.Invoke(null, [fixture, fileName]);

        return fixture;
    }
    
    public static IFixture AddModel<T>(this IFixture fixture, params string[] fileName)
    {
        fixture.Customizations.Add(new ModelSpecimenBuilder<T>(fileName));
        return fixture;
    }
}