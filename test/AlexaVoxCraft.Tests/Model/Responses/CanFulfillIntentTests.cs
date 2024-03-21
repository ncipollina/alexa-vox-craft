using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses;

public class CanFulfillIntentTests
{
    [Fact]
    public void Should_Create_Same_Intent_As_Json_Example()
    {
        var fulfillIntent = new CanFulfillIntent
        {
            CanFulfill = CanFulfill.YES,
            Slots =
            {
                {
                    "slotName", new()
                    {
                        CanUnderstand = CanUnderstand.YES,
                        CanFulfill = SlotCanFulfill.NO
                    }
                }
            }
        };

        Utility.CompareJson(fulfillIntent, "CanFulfillResponse.json");
    }
}