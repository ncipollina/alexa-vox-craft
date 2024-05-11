using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class LoadTokenListDataRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "LoadTokenListDataRequest.json")]
    public void Can_Deserialize_LoadTokenListDataRequest_Json(RequestType request)
    {
        var loadTokenListDataRequest = request.Should().NotBeNull().And.BeOfType<LoadTokenListDataRequest>().Subject;
        Utility.CompareJson(loadTokenListDataRequest, "LoadTokenListDataRequest.json");
    }
}