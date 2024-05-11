using System.Text.Json;
using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Apl.Directives;
using AlexaVoxCraft.Model.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Apl.Directives;

public class APLDocumentTests
{
    [Theory]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.0", APLDocumentVersion.V1)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.1", APLDocumentVersion.V1_1)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.2", APLDocumentVersion.V1_2)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.3", APLDocumentVersion.V1_3)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.4", APLDocumentVersion.V1_4)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.5", APLDocumentVersion.V1_5)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.6", APLDocumentVersion.V1_6)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.7", APLDocumentVersion.V1_7)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.8", APLDocumentVersion.V1_8)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "1.9", APLDocumentVersion.V1_9)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "2022.1", APLDocumentVersion.V2022_1)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "2022.2", APLDocumentVersion.V2022_2)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "2023.1", APLDocumentVersion.V2023_1)]
    [InlineModelAutoData(typeof(Directive), "APL/Directives/RenderDocument.json", "2023.2", APLDocumentVersion.V2023_2)]
    
    public void Can_Set_Top_Level_Properties(string versionString, APLDocumentVersion version, Directive directive)
    {
        var doc = GetDocument(directive, version);
        doc.Version.Should().Be(version);
        doc.VersionString.Should().Be(versionString);
        doc.MainTemplate.Should().NotBeNull();
    }
    
    [Theory, ModelAutoData(typeof(IEnumerable<Resource>), "APL/Directives/Resource.json")]
    public void Resources(List<Resource> resources)
    {
        resources.Count.Should().Be(2);

        var first = resources.First();
        first.Dimensions.Count.Should().Be(2);
        first.Dimensions.First().Key.Should().Be("myFontSize");
        first.Dimensions.First().Value.GetValue().Should().Be("28dp");

        var second = resources.Skip(1).First();
        second.When.Should().Be(When.RoundViewport);
        second.Resources.Count().Should().Be(2);
    }

    
    [Fact]
    public void Styles()
    {
        var json = File.ReadAllText(Path.Combine("Model", "Examples", "APL/Directives/Styles.json"));
        var styles = JsonSerializer.Deserialize<Dictionary<string, Style>>(json, new JsonSerializerOptions(AlexaJsonOptions.DefaultOptions)); 
        
        styles.Should().NotBeNull().And.BeOfType<Dictionary<string, Style>>();
        Utility.CompareJson(styles, "APL/Directives/Styles.json");
    }

    [Theory, ModelAutoData(typeof(Import), "APL/Directives/Import.json")]
    public void Detailed_Import(Import import)
    {
        import.Should().NotBeNull().And.BeOfType<Import>();
        Utility.CompareJson(import, "APL/Directives/Import.json");
    }

    private APLDocument GetDocument(Directive directive, APLDocumentVersion? version = null)
    {
        var doc =
            directive.Should().NotBeNull().And.BeOfType<APLRenderDocumentDirective>().Subject.Document.Should()
                .NotBeNull().And.BeOfType<APLDocument>().Subject;
        if (version.HasValue)
        {
            doc.Version = version.Value;
        }

        return doc;
    }
}