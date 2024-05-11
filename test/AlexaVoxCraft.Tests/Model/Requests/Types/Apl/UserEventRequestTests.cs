using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class UserEventRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "UserEvent.json")]
    public void Can_Deserialize_UserEventRequest_Json(RequestType request)
    {
        var userEventRequest = request.Should().NotBeNull().And.BeOfType<UserEventRequest>().Subject;
        Utility.CompareJson(userEventRequest, "UserEvent.json");
    }
}