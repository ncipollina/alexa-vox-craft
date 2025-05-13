using AlexaVoxCraft.Model.Apl.VectorGraphics;
using Xunit;

namespace AlexaVoxCraft.Model.Apl.Tests;

public class VectorGraphicTests
{
    [Fact]
    public void AVGGeneratesCorrectJson()
    {
        Utility.AssertSerialization<AVG>("AVG.json");
    }
}