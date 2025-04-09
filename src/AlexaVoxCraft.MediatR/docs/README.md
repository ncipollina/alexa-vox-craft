# AlexaVoxCraft.MediatR

Contains the base request pipeline and interfaces used for routing Alexa requests using MediatR. This includes:

- `IHandlerInput` abstraction
- Handler resolution via `ICanHandle`
- Custom `IExceptionHandler` interface for error handling

## ✅ Features

- Works with MediatR and System.Text.Json
- AddSkillMediator extension for easy registration
- Structured and extensible pipeline

## 🚀 Getting Started

Install the package:

```bash
dotnet add package AlexaVoxCraft.MediatR
```

Implement a handler:

```csharp
public sealed class MyIntentHandler : IRequestHandler<IntentRequest>
{
    public bool CanHandle(IHandlerInput input) =>
        input.RequestEnvelope.Request is IntentRequest r && r.Intent.Name == "MyIntent";

    public Task<SkillResponse> Handle(IHandlerInput input, CancellationToken cancellationToken)
    {
        return Task.FromResult(input.ResponseBuilder.Speak("Handled").GetResponse());
    }
}
```

## 📄 License

Apache-2.0