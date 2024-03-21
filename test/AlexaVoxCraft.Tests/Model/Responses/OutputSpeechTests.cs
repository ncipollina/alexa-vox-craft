using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses;

public class OutputSpeechTests
{
    [Fact]
    public void Can_Serialize_PlainTextOutputSpeech_To_Json()
    {
        var plainTextOutputSpeech = new PlainTextOutputSpeech { Text = "text content" };
        Utility.CompareJson(plainTextOutputSpeech, "PlainTextOutputSpeech.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(OutputSpeech), "PlainTextOutputSpeech.json")]
    public void Can_Deserialize_PlainTextOutputSpeech_Json(OutputSpeech speech)
    {
        var plainTextOutputSpeech = speech.Should().NotBeNull().And.BeOfType<PlainTextOutputSpeech>().Subject;

        plainTextOutputSpeech.Text.Should().Be("text content");
        plainTextOutputSpeech.PlayBehavior.Should().BeNull();
    }
    
    [Fact]
    public void Can_Serialize_PlainTextOutputSpeech_With_PlayBehavior_To_Json()
    {
        var plainTextOutputSpeech = new PlainTextOutputSpeech { Text = "text content", PlayBehavior = PlayBehavior.ReplaceAll};
        Utility.CompareJson(plainTextOutputSpeech, "PlainTextOutputSpeechWithPlayBehavior.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(OutputSpeech), "PlainTextOutputSpeechWithPlayBehavior.json")]
    public void Can_Deserialize_PlainTextOutputSpeech_With_PlayBehavior_Json(OutputSpeech speech)
    {
        var plainTextOutputSpeech = speech.Should().NotBeNull().And.BeOfType<PlainTextOutputSpeech>().Subject;

        plainTextOutputSpeech.Text.Should().Be("text content");
        plainTextOutputSpeech.PlayBehavior.Should().Be(PlayBehavior.ReplaceAll);
    }
    
    [Fact]
    public void Can_Serialize_SsmlextOutputSpeech_To_Json()
    {
        var plainTextOutputSpeech = new SsmlOutputSpeech { Ssml = "ssml content" };
        Utility.CompareJson(plainTextOutputSpeech, "SsmlOutputSpeech.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(OutputSpeech), "SsmlOutputSpeech.json")]
    public void Can_Deserialize_SsmlTextOutputSpeech_Json(OutputSpeech speech)
    {
        var plainTextOutputSpeech = speech.Should().NotBeNull().And.BeOfType<SsmlOutputSpeech>().Subject;

        plainTextOutputSpeech.Ssml.Should().Be("ssml content");
        plainTextOutputSpeech.PlayBehavior.Should().BeNull();
    }
    
    [Fact]
    public void Can_Serialize_SsmlTextOutputSpeech_With_PlayBehavior_To_Json()
    {
        var plainTextOutputSpeech = new SsmlOutputSpeech { Ssml = "ssml content", PlayBehavior = PlayBehavior.ReplaceEnqueued};
        Utility.CompareJson(plainTextOutputSpeech, "SsmlOutputSpeechWithPlayBehavior.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(OutputSpeech), "SsmlOutputSpeechWithPlayBehavior.json")]
    public void Can_Deserialize_SsmlTextOutputSpeech_With_PlayBehavior_Json(OutputSpeech speech)
    {
        var plainTextOutputSpeech = speech.Should().NotBeNull().And.BeOfType<SsmlOutputSpeech>().Subject;

        plainTextOutputSpeech.Ssml.Should().Be("ssml content");
        plainTextOutputSpeech.PlayBehavior.Should().Be(PlayBehavior.ReplaceEnqueued);
    }
}