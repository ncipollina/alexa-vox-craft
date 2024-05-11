using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class ContextTests
{
    [Theory, ModelAutoData(typeof(Context), "GetScopes.json")]
    public void Can_Read_Scopes_Example(Context context)
    {
        context.Should().NotBeNull();

        var scope = context.System.User.Permissions.Scopes.Should()
            .Contain(s => s.Key == "alexa::devices:all:geolocation:read").Subject.Value;
        scope.Status.Should().Be("GRANTED");
    }
}