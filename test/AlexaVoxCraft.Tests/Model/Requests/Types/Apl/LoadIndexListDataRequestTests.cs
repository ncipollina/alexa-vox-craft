using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class LoadIndexListDataRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "LoadIndexListDataRequest.json")]
    public void Can_Deserialize_LoadIndexListDataRequest_Json(RequestType request)
    {
        var loadIndexListDataRequest = request.Should().NotBeNull().And.BeOfType<LoadIndexListDataRequest>().Subject;
        Utility.CompareJson(loadIndexListDataRequest, "LoadIndexListDataRequest.json");
    }
}