using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class HintDirectiveTest
{
    [Fact]
    public void Create_HintDirective()
    {
        var actual = new HintDirective { Hint = new Hint { Text = "test hint", Type = TextType.Plain } };

        Utility.CompareJson(actual, "HintDirective.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(Directive), "HintDirective.json")]
    public void Can_Deserialize_HintDirective_Json(Directive directive)
    {
        var hintDirective = directive.Should().NotBeNull().And.BeOfType<HintDirective>().Subject;

        hintDirective.Hint.Type.Should().Be("PlainText");
        hintDirective.Hint.Text.Should().Be("test hint");
    }
}