using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class RuntimeErrorRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "RuntimeError.json")]
    public void Can_Deserialize_RuntimeErrorRequest_Json(RequestType request)
    {
        var runtimeErrorRequest = request.Should().NotBeNull().And.BeOfType<RuntimeErrorRequest>().Subject;
        Utility.CompareJson(runtimeErrorRequest, "RuntimeError.json");
    }
}