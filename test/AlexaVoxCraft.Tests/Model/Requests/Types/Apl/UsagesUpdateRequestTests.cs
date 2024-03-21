using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class UsagesUpdateRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "UsagesUpdateRequest.json")]
    public void Can_Deserialize_UsagesUpdateRequest_Json(RequestType request)
    {
        var updateRequest = request.Should().NotBeNull().And.BeOfType<UsagesUpdateRequest>().Subject;
        Utility.CompareJson(updateRequest, "UsagesUpdateRequest.json");

        updateRequest.PackageId.Should().Be("WeatherWidget");
        updateRequest.FromVersion.Should().Be("1.0.0");
        updateRequest.ToVersion.Should().Be("1.0.1");
    }
}