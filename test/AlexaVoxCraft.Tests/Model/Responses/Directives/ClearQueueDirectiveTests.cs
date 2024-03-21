using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class ClearQueueDirectiveTests
{
    [Theory, ModelAutoData(typeof(Directive), "ClearQueueDirective.json")]
    public void Can_Deserialize_ClearQueueDirective_Json(Directive directive)
    {
        var clearQueueDirective = directive.Should().NotBeNull().And.BeOfType<ClearQueueDirective>().Subject;

        clearQueueDirective.ClearBehavior.Should().Be(ClearBehavior.ClearAll);
    }
}