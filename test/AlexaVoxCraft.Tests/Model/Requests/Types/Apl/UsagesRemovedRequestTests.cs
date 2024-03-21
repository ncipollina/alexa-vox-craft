using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class UsagesRemovedRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "UsagesRemovedRequest.json")]
    public void Can_Deserialize_UsagesRemovedRequest_Json(RequestType request)
    {
        var removedRequest = request.Should().NotBeNull().And.BeOfType<UsagesRemovedRequest>().Subject;
        Utility.CompareJson(removedRequest, "UsagesRemovedRequest.json");

        removedRequest.Payload.PackageId.Should().Be("WeatherWidget");
        removedRequest.Payload.PackageVersion.Should().Be("1.0.0");

        var usage = removedRequest.Payload.Usages.Should().ContainSingle().Subject;
        usage.InstanceId.Should().Be("amzn1.ask.package.v1.instance.v1.{uuid}");
        usage.Location.Should().Be(UsageLocation.FAVORITE);
    }
}