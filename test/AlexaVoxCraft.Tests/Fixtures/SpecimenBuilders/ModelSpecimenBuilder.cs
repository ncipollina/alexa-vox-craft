using System.Text.Json;
using AlexaVoxCraft.Model.Serialization;
using AlexaVoxCraft.Tests.Fixtures.RequestSpecifications;
using AutoFixture.Kernel;

namespace AlexaVoxCraft.Tests.Fixtures.SpecimenBuilders;

public class ModelSpecimenBuilder<T>(params string[] fileName) : ISpecimenBuilder
{
    private static readonly string ExamplesPath = "Examples";
    private static readonly string ModelPath = "Model";
    private static readonly string[] BasePath = [ModelPath, ExamplesPath];

    private static JsonSerializerOptions Options = new(AlexaJsonOptions.DefaultOptions);

    private readonly IRequestSpecification _requestSpecification = new ModelRequestSpecification<T>();

    public object Create(object request, ISpecimenContext context)
    {
        if (!_requestSpecification.IsSatisfiedBy(request))
            return new NoSpecimen();

        return GetObjectFromExample(fileName);
    }

    private T? GetObjectFromExample(params string[] filename)
    {
        var json = File.ReadAllText(Path.Combine(BasePath.Concat(filename).ToArray()));
        return JsonSerializer.Deserialize<T>(json, Options);
    }
}