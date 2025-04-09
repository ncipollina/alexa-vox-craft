# 🔣 Alexa Vox Craft

**Alexa Vox Craft** is a modular, opinionated library for building Alexa skills in C# using .NET. It leverages `System.Text.Json`, MediatR patterns, and extensible components for building and maintaining robust Alexa skills with support for:

- ✅ Clean separation of concerns using MediatR
- ✅ JSON (de)serialization with full control via `System.Text.Json`
- ✅ APL (Alexa Presentation Language) model support and utilities
- ✅ Custom converters for object, enum, and polymorphic types
- ✅ Lambda-ready with logging, tracing, and testability in mind

### What does "AlexaVoxCraft" mean?

- **Alexa**: Represents the integration with Amazon Alexa, the voice service powering devices like Amazon Echo.
- **VoxCraft**: Signifies the focus on voice-driven interactions, leveraging the VoxCraft framework.

> 📦 **Credits:**
>
> - The core Alexa skill models (`AlexaVoxCraft.Model`) are based on the excellent work in [timheuer/alexa-skills-dotnet](https://github.com/timheuer/alexa-skills-dotnet).
> - APL support (`AlexaVoxCraft.Model.Apl`) is based on [stoiveyp/Alexa.NET.APL](https://github.com/stoiveyp/Alexa.NET.APL).

---

## 🏎️ Packages

| Package                          | Build Status                                                                                                                                                                  | NuGet                                                                                                                                       | GitHub | Downloads                                                                                                                                            |
|----------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|--------|------------------------------------------------------------------------------------------------------------------------------------------------------|
| **AlexaVoxCraft.Model**          | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)  | [![NuGet](https://img.shields.io/nuget/vpre/AlexaVoxCraft.Model.svg)](https://www.nuget.org/packages/AlexaVoxCraft.Model)                   | [📁 Source](src/AlexaVoxCraft.Model) | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.Model.svg)](https://www.nuget.org/packages/AlexaVoxCraft.Model/)                   |
| **AlexaVoxCraft.Model.Apl**      | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)  | [![NuGet](https://img.shields.io/nuget/vpre/AlexaVoxCraft.Model.Apl.svg)](https://www.nuget.org/packages/AlexaVoxCraft.Model.Apl)           | [📁 Source](src/AlexaVoxCraft.Model.Apl) | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.Model.Apl.svg)](https://www.nuget.org/packages/AlexaVoxCraft.Model.Apl/)           |
| **AlexaVoxCraft.MediatR.Lambda** | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)  | [![NuGet](https://img.shields.io/nuget/vpre/AlexaVoxCraft.MediatR.Lambda.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR.Lambda) | [📁 Source](src/AlexaVoxCraft.MediatR.Lambda) | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.MediatR.Lambda.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR.Lambda/) |
| **AlexaVoxCraft.MediatR**        | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)  | [![NuGet](https://img.shields.io/nuget/vpre/AlexaVoxCraft.MediatR.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR)               | [📁 Source](src/AlexaVoxCraft.MediatR.Lambda) | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.MediatR.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR/)               |

---

## 🚀 Getting Started

### 1. Install Required Packages

Install only the packages you need! If you're not using MediatR or APL features, you can omit those dependencies.

```bash
dotnet add package AlexaVoxCraft.Model
# Optional:
dotnet add package AlexaVoxCraft.MediatR.Lambda
```

### 2. Create a Lambda Entry Point

```csharp
await LambdaHostExtensions.RunAlexaSkill<YourAlexaSkillFunction>();
```

### 3. Create Your Function Class

```csharp
public sealed class YourAlexaSkillFunction : AlexaSkillFunction<SkillRequest, SkillResponse>
{
    protected override void Init(IHostBuilder builder)
    {
        builder.UseSerilog((context, services, configuration) =>
            {
                configuration.ReadFrom.Configuration(context.Configuration)
                    .ReadFrom.Services(services)
                    .Enrich.FromLogContext();
            })
            .UseHandler<LambdaHandler, SkillRequest, SkillResponse>()
            .ConfigureServices((context, services) =>
            {
                services.AddSkillMediator(context.Configuration,
                    cfg => { cfg.RegisterServicesFromAssemblyContaining<Program>(); });
            });
    }
}
```

### 4. Handle Requests with MediatR

Handlers in AlexaVoxCraft are expected to implement `IRequestHandler<T>` and optionally implement `ICanHandle` to provide routing logic.

```csharp
public sealed class LaunchRequestHandler : IRequestHandler<LaunchRequest>
{
    public bool CanHandle(IHandlerInput handlerInput) =>
        handlerInput.RequestEnvelope.Request is LaunchRequest;

    public async Task<SkillResponse> Handle(IHandlerInput input, CancellationToken cancellationToken = default)
    {
        return await input.ResponseBuilder.Speak("Hello world!").WithShouldEndSession(true)
            .GetResponse(cancellationToken);
    }
}
```

---

## 🧪 Unit Testing

Sample projects show how to load Alexa requests from JSON and assert deserialized structure. Tests include validation of:

- Correct parsing of SkillRequest types
- APL component deserialization
- Proper usage of custom converters

---

## 🛠 Utilities and Helpers

- `EnumHelper`: Convert to/from `[EnumMember]`-decorated enums
- `ObjectConverter`: Deserialize polymorphic object values
- `BasePolymorphicConverter<T>`: Handle APL and directive subtypes
- `AlexaLambdaSerializer`: Custom `ILambdaSerializer` with logging support

---

## ⚠️ Error Handling

To intercept and respond to exceptions in your MediatR pipeline, implement the `IExceptionHandler` interface:

```csharp
public sealed class MyExceptionHandler : IExceptionHandler
{
    public Task<bool> CanHandle(IHandlerInput handlerInput, Exception ex, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(true); // Catch all
    }

    public Task<SkillResponse> Handle(IHandlerInput handlerInput, Exception ex, CancellationToken cancellationToken = default)
    {
        var response = handlerInput.ResponseBuilder.Speak("Something went wrong. Please try again.");
        return response.GetResponse(cancellationToken);
    }
}
```

No manual registration is required. Exception handlers are picked up automatically via `AddSkillMediator(...)`.

---

## 🛁 Sample Projects

| Sample Project                                              | Description                                        |
|-------------------------------------------------------------|----------------------------------------------------|
| [`Sample.Skill.Function`](samples/Sample.Skill.Function)   | A minimal Alexa skill using this library           |
| [`Sample.Apl.Function`](samples/Sample.Apl.Function)       | A sample APL skill to demonstrate working with APL |

Each sample demonstrates MediatR integration, serialization support, custom directives, and Lambda bootstrapping.

---

## 🤭 Roadmap

- ✅ Full widget lifecycle support
- ✅ Advanced directive handling
- ⚖️ OpenTelemetry & logging enrichment
- 🔄 Documentation site

---

## 🤝 Contributing

PRs are welcome! Please submit issues and ideas to help make this toolkit even better.

---

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ncipollina"><img src="https://avatars.githubusercontent.com/u/1405469?v=4?s=100" width="100px;" alt="Nick Cipollina"/><br /><sub><b>Nick Cipollina</b></sub></a><br /><a href="#content-ncipollina" title="Content">🔓</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!

---

## 📜 License

MIT
