using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class UsagesInstalledRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "UsagesInstalledRequest.json")]
    public void Can_Deserialize_UsagesInstalledRequest_Json(RequestType request)
    {
        var installedRequest = request.Should().NotBeNull().And.BeOfType<UsagesInstalledRequest>().Subject;
        Utility.CompareJson(installedRequest, "UsagesInstalledRequest.json");

        installedRequest.Payload.PackageId.Should().Be("WeatherWidget");
        installedRequest.Payload.PackageVersion.Should().Be("1.0.0");

        var usage = installedRequest.Payload.Usages.Should().ContainSingle().Subject;
        usage.InstanceId.Should().Be("amzn1.ask.package.v1.instance.v1.{uuid}");
        usage.Location.Should().Be(UsageLocation.FAVORITE);
    }
}