using System.Xml.Linq;
using AlexaVoxCraft.Model.Responses.Ssmls;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Responses.Ssmls;

public class SsmlTests
{
    [Fact]
    public void Ssml_Error_With_No_Text()
    {
        var ssml = new Speech();

        Action action = () => _ = ssml.ToXml();

        action.Should().Throw<InvalidOperationException>();
    }

    [Theory, SsmlAutoData]
    public void Ssml_Generates_Speak_And_Elements(string text)
    {
        var expected = $"<speak>{text}</speak>";
        var ssml = new Speech();

        ssml.Elements.Add(new PlainText(text));
        var actual = ssml.ToXml();

        actual.Should().Be(expected);
    }

    [Theory, SsmlAutoData]
    public void Ssml_PlainText_Generates_Text(string text)
    {
        var actual = new PlainText(text);

        CompareXml(text, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Sentence_With_Text_Generates_s(string text)
    {
        var expected = $"<s>{text}</s>";

        var actual = new Sentence(text);

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Paragraph_Generates_p(string text)
    {
        var expected = $"<p>{text}</p>";

        var actual = new Paragraph();
        actual.Elements.Add(new PlainText(text));

        CompareXml(expected, actual);
    }

    [Fact]
    public void Ssml_Break_Generates_Break()
    {
        const string expected = "<break />";

        var actual = new Break();

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Break_Generates_Time_Attribute(int seconds)
    {
        var expected = $"<break time=\"{seconds}s\" />";

        var actual = new Break { Time = $"{seconds}s" };

        CompareXml(expected, actual);
    }

    [Fact]
    public void Ssml_Break_Generates_Strength()
    {
        const string expected = @"<break strength=""x-weak"" />";

        var actual = new Break { Strength = BreakStrength.ExtraWeak };

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Sayas_Generates_Sayas(string text)
    {
        var expected = $"<say-as interpret-as=\"spell-out\">{text}</say-as>";

        var actual = new SayAs(text, InterpretAs.SpellOut);

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Sayas_Generates_Format(string text)
    {
        var expected = $"<say-as interpret-as=\"spell-out\" format=\"ymd\">{text}</say-as>";

        var actual = new SayAs(text, InterpretAs.SpellOut) { Format = "ymd" };

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Word_Generates_w(string text)
    {
        var expected = $"<w role=\"amazon:VB\">{text}</w>";

        var actual = new Word(text, WordRole.Verb);

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Sub_generates_sub(string text, string alias)
    {
        var expected = $"<sub alias=\"{alias}\">{text}</sub>";

        var actual = new Sub(text, alias);

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Prosody_generates_prosody(string text)
    {
        var expected = $"<prosody rate=\"150%\" pitch=\"x-low\" volume=\"-5dB\">{text}</prosody>";

        var actual = new Prosody
        {
            Rate = ProsodyRate.Percent(150),
            Pitch = ProsodyPitch.ExtraLow,
            Volume = ProsodyVolume.Decibel(-5)
        };

        actual.Elements.Add(new PlainText(text));

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Emphasis_generates_emphasis(string text)
    {
        var expected = $"<emphasis level=\"strong\">{text}</emphasis>";

        var actual = new Emphasis(text);
        actual.Level = EmphasisLevel.Strong;

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Phoneme_generates_phoneme(string text)
    {
        var expected = $"<phoneme alphabet=\"ipa\" ph=\"pɪˈkɑːn\">{text}</phoneme>";

        var actual = new Phoneme(text, PhonemeAlphabet.International, "pɪˈkɑːn");

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Audio_generate_audio(string text)
    {
        var expected = $"<audio src=\"http://example.com/example.mp3\">{text}</audio>";

        var actual = new Audio("http://example.com/example.mp3");
        actual.Elements.Add(new PlainText(text));

        CompareXml(expected, actual);
    }

    [Theory, SsmlAutoData]
    public void Ssml_Amazon_Effect_generate_amazon_effect(string text)
    {
        var expected = $"<speak><amazon:effect name=\"whispered\">{text}</amazon:effect></speak>";

        var effect = new AmazonEffect(text);

        //Can't use Comparexml because this tag has meant a change to the speech element ToXml method
        var xmlHost = new Speech();
        xmlHost.Elements.Add(effect);
        var actual = xmlHost.ToXml();

        actual.Should().Be(expected);
    }

    [Theory, SsmlAutoData]
    public void TerseSsml_Produces_Identical_Xml(string speech1, string speech2, string speech3)
    {
        var expected = new Speech
        {
            Elements = new List<ISsml>
            {
                new Paragraph
                {
                    Elements = new List<IParagraphSsml>
                    {
                        new PlainText(speech1),
                        new Prosody
                        {
                            Rate = ProsodyRate.Fast,
                            Elements = new List<ISsml> { new Sentence(speech2) }
                        },
                        new Sentence(speech3)
                    }
                }
            }
        };

        var actual = new Speech(
            new Paragraph(
                new PlainText(speech1),
                new Prosody(new Sentence(speech2)) { Rate = ProsodyRate.Fast },
                new Sentence(speech3)
            ));

        expected.ToXml().Should().Be(actual.ToXml());
    }

    [Fact]
    public void Ssml_VoiceAndLang_GenerateCorrectly()
    {
        var expected = "<voice name=\"Celine\"><lang xml:lang=\"fr-FR\">Je ne parle pas francais</lang></voice>";
        var speech =
            new Voice("Celine",
                new Lang("fr-FR", new PlainText("Je ne parle pas francais"))
            );
        CompareXml(expected, speech);
    }

    [Fact]
    public void Ssml_Alexa_Name_generate_alexa_name()
    {
        const string expected = "<speak><alexa:name type=\"first\" personId=\"amzn1.ask.person.ABCDEF\" /></speak>";

        var alexaName = new AlexaName("amzn1.ask.person.ABCDEF");

        var xmlHost = new Speech();
        xmlHost.Elements.Add(alexaName);
        var actual = xmlHost.ToXml();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Ssml_AmazonDomain_generate_domain()
    {
        const string expected = @"<speak><amazon:domain name=""news"">A miniature manuscript</amazon:domain></speak>";

        var xmlHost = new Speech();
        var actual = new AmazonDomain(DomainName.News);
        actual.Elements.Add(new PlainText("A miniature manuscript"));
        xmlHost.Elements.Add(actual);
        Assert.Equal(expected, xmlHost.ToXml());
    }

    [Fact]
    public void Ssml_AmazonEmotion_generate_emotion()
    {
        const string expected =
            @"<speak><amazon:emotion name=""excited"" intensity=""medium"">Christina wins this round!</amazon:emotion></speak>";

        var xmlHost = new Speech();
        var actual = new AmazonEmotion(EmotionName.Excited, EmotionIntensity.Medium);
        actual.Elements.Add(new PlainText("Christina wins this round!"));
        xmlHost.Elements.Add(actual);
        Assert.Equal(expected, xmlHost.ToXml());
    }

    private void CompareXml(string expected, ISsml ssml)
    {
        var actual = ssml.ToXml().ToString(SaveOptions.DisableFormatting);
        actual.Should().Be(expected);
    }
}