using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Apl.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Apl.Directives;

public class RenderDocumentDirectiveTests
{
    [Theory, ModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json")]
    public void Can_Deserialize_RenderDocumentDirective_Json(Directive directive)
    {
        var renderDirective = directive.Should().NotBeNull().And.BeOfType<APLRenderDocumentDirective>().Subject;

        Utility.CompareJson(renderDirective, "APL/Directives/RenderDocument.json");
    }

    [Theory, ModelAutoData(typeof(Directive), "APL/Directives/InputDirectiveTest.json")]
    public void Can_Deserialize_Complex_RenderDocumentDirective_Json(Directive directive)
    {
        var renderDirective = directive.Should().NotBeNull().And.BeOfType<APLRenderDocumentDirective>().Subject;

        Utility.CompareJson(renderDirective, "APL/Directives/InputDirectiveTest.json");
    }
}