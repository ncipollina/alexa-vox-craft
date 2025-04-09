using System.Text;
using AlexaVoxCraft.MediatR;
using AlexaVoxCraft.Model.Apl;
using AlexaVoxCraft.Model.Apl.Commands;
using AlexaVoxCraft.Model.Apl.Components;
using AlexaVoxCraft.Model.Response;

namespace Sample.Apl.Function.Handlers;

public class DefaultHandler : IDefaultRequestHandler
{
    public Task<bool> CanHandle(IHandlerInput input, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(true);
    }

    public async Task<SkillResponse> Handle(IHandlerInput input, CancellationToken cancellationToken = default)
    {
        var speechOutput = new StringBuilder("Hello world!");
        var document = new APLDocument(APLDocumentVersion.V2023_2)
        {
            Layouts = new Dictionary<string, Layout>
            {
                ["TextFrame"] = new Layout
                {
                    Parameters = new List<Parameter>
                    {
                        "text",
                        "color"
                    },
                    Items = new List<APLComponent>
                    {
                        new Frame
                        {
                            BorderColor = "${color}",
                            BorderWidth = 5,
                            Height = "100%",
                            Width = "100%",
                            Shrink = 1,
                            Item = new List<APLComponent>
                            {
                                new Text
                                {
                                    Content = "${text}",
                                    TextAlign = "center",
                                    Width = "100%",
                                    Height = "100%",
                                    TextAlignVertical = "center"
                                }
                            }
                        }
                    }
                }
            },
            MainTemplate = new Layout(new Container
            {
                Id = "main",
                Width = "100%",
                Height = "100%",
                Padding = new List<int> { 20 },
                Items = new List<APLComponent>
                {
                    new CustomComponent("TextFrame")
                    {
                        Id = "textFrame",
                        Properties = new Dictionary<string, object>
                        {
                            ["text"] = "Hello world!",
                            ["color"] = "yellow"
                        }
                    }
                }!
            }),
            OnMount = new List<APLCommand>
            {
                new InsertItem
                {
                    DelayMilliseconds = 5000,
                    ComponentId = "main",
                    Items = new List<object>
                    {
                        new CustomComponent("TextFrame")
                        {
                            Id = "textFrame",
                            Properties = new Dictionary<string, object>
                            {
                                ["text"] = "Hello world!",
                                ["color"] = "yellow"
                            }
                        }
                    },
                }
            }
        };
        var directive = new RenderDocumentDirective
        {
            Document = document
        };
        if (input.RequestEnvelope.APLSupported())
        {
            speechOutput.Clear();


            input.ResponseBuilder.AddDirective(directive);
        }
        return await input.ResponseBuilder
            .Speak(speechOutput.ToString())
            .Reprompt(speechOutput.ToString())
            .WithSimpleCard("APL Sample", speechOutput.ToString())
            .GetResponse(cancellationToken);
    }
}