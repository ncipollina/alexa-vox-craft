using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class InstallationErrorRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "InstallationError.json")]
    public void Can_Deserialize_InstallationErrorRequest_Json(RequestType request)
    {
        var errorRequest = request.Should().NotBeNull().And.BeOfType<InstallationErrorRequest>().Subject;
        Utility.CompareJson(errorRequest, "InstallationError.json");

        errorRequest.PackageId.Should().Be("WeatherWidget");
        errorRequest.Version.Should().Be("1.0.0");
        errorRequest.Error.Type.Should().Be(InstallationErrorType.PACKAGEMANAGER_INTERNAL_ERROR);
    }
}