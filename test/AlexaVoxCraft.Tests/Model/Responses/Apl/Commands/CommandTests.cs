using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Apl.Commands;

public class CommandTests
{
    [Fact]
    public void Can_Serialize_SpeakItem_Json()
    {
        var speakItem = new SpeakItem
        {
            ComponentId = "ComponentId"
        };
        
        Utility.CompareJson(speakItem, "APL/Commands/SpeakItem.json");
    }
}