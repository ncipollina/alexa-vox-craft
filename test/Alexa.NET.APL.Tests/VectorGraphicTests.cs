using AlexaVoxCraft.Model.Apl.VectorGraphics;
using Xunit;

namespace Alexa.NET.APL.Tests;

public class VectorGraphicTests
{
    [Fact]
    public void AVGGeneratesCorrectJson()
    {
        Utility.AssertSerialization<AVG>("AVG.json");
    }
}