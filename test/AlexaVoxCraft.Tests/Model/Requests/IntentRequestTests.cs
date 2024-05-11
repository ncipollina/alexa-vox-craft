using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class IntentRequestTests
{
    [Theory, ModelAutoData(typeof(IntentRequest), "IntentWithResolution.json")]
    public void Can_Read_Intent_With_Entity_Resolution(IntentRequest request)
    {
        request.Should().NotBeNull();
        var intent = request.Intent;
        var mediaTypeSlot = intent.Slots.Should().Contain(s => s.Key == "MediaType").Subject.Value;
        var mediaTitleSlot = intent.Slots.Should().Contain(s => s.Key == "MediaTitle").Subject.Value;

        var mediaTypeResolutionAuthority = new Resolution
        {
            Authorities = new[]
            {
                new ResolutionAuthority
                {
                    Name = "amzn1.er-authority.echo-sdk.<skill_id>.MEDIA_TYPE",
                    Status = new ResolutionStatus { Code = ResolutionStatusCode.SuccessfulMatch },
                    Values = new[]
                    {
                        new ResolutionValueContainer
                        {
                            Value = new ResolutionValue
                            {
                                Name = "song",
                                Id = "SONG"
                            }
                        }
                    }
                }
            }
        };

        var mediaTitleResolutionAuthority = new Resolution
        {
            Authorities = new[]
            {
                new ResolutionAuthority
                {
                    Name = "amzn1.er-authority.echo-sdk.<skill_id>.MEDIA_TITLE",
                    Status = new ResolutionStatus { Code = ResolutionStatusCode.SuccessfulMatch },
                    Values = new[]
                    {
                        new ResolutionValueContainer
                        {
                            Value = new ResolutionValue
                            {
                                Name = "Rolling in the Deep",
                                Id = "song_id_456"
                            }
                        }
                    }
                }
            }
        };

        Utility.CompareObjectJson(mediaTypeSlot.Resolution, mediaTypeResolutionAuthority).Should().BeTrue();
        Utility.CompareObjectJson(mediaTitleSlot.Resolution, mediaTitleResolutionAuthority).Should().BeTrue();
    }
}