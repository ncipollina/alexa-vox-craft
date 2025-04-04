using AlexaVoxCraft.Model.Apl.Package;
using Xunit;

namespace Alexa.NET.APL.Tests;

public class APLPackageTests
{
    [Fact]
    public void ValidPackageDocument()
    {
        Utility.AssertSerialization<APLPackage>("APLPackage.json");
    }
}