using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class StopDirectiveTests
{
    [Theory, ModelAutoData(typeof(Directive), "StopDirective.json")]
    public void Can_Deserialize_StopDirective_Json(Directive directive)
    {
        directive.Should().NotBeNull().And.BeOfType<StopDirective>();
    }
}