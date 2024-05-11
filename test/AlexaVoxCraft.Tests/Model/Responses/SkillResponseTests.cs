using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses;

public class SkillResponseTests
{
    [Fact]
    public void Should_Create_Same_Json_Response_As_Example()
    {
        var skillResponse = new SkillResponse
        {
            Version = "1.0",
            SessionAttributes = new Dictionary<string, object>
            {
                {
                    "supportedHoriscopePeriods", new
                    {
                        daily = true,
                        weekly = false,
                        monthly = false
                    }
                }
            },
            Response = new()
            {
                OutputSpeech = new PlainTextOutputSpeech
                {
                    Text =
                        "Today will provide you a new learning opportunity. Stick with it and the possibilities will be endless. Can I help you with anything else?"
                },
                Card = new SimpleCard
                {
                    Title = "Horoscope",
                    Content = "Today will provide you a new learning opportunity. Stick with it and the possibilities will be endless."
                },
                ShouldEndSession = false
            }
        };

        Utility.CompareJson(skillResponse, "Response.json").Should().BeTrue();
    }
}