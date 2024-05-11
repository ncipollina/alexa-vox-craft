using AutoFixture.Kernel;

namespace AlexaVoxCraft.Tests.Fixtures.RequestSpecifications;

public class ModelRequestSpecification<T> : IRequestSpecification
{
    public bool IsSatisfiedBy(object request)
    {
        return request is Type type && type == typeof(T);
    }
}