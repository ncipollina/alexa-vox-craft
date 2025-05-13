using AlexaVoxCraft.Model.Apl.Package;
using Xunit;

namespace AlexaVoxCraft.Model.Apl.Tests;

public class APLPackageTests
{
    [Fact]
    public void ValidPackageDocument()
    {
        Utility.AssertSerialization<APLPackage>("APLPackage.json");
    }
}