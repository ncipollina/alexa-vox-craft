using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class ResolutionTests
{
    [Theory, ModelAutoData(typeof(Resolution), "Resolution.json")]
    public void Can_Read_Resolution(Resolution resolution)
    {
        resolution.Should().NotBeNull();
        Utility.CompareJson(resolution, "Resolution.json").Should().BeTrue();
    }
}