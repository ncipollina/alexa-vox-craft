using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Ssmls;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Responses;

public class RepromptTests
{
    [Theory, RepromptAutoData]
    public void Reprompt_String_Generates_PlainTextOutput(string text)
    {
        var result = new Reprompt(text);
        var plainText = result.OutputSpeech.Should().NotBeNull().And.BeOfType<PlainTextOutputSpeech>().Subject;
        plainText.Text.Should().Be(text);
    }

    [Theory, RepromptAutoData]
    public void Reprompt_Ssml_Generates_SsmlOutput(string text)
    {
        var speech = new Speech(new PlainText("text"));
        var result = new Reprompt(speech);
        var ssmlText = result.OutputSpeech.Should().NotBeNull().And.BeOfType<SsmlOutputSpeech>().Subject;
        ssmlText.Ssml.Should().BeEquivalentTo(speech.ToXml());
    }
}