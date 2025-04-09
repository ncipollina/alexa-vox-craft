# AlexaVoxCraft.MediatR.Lambda

Provides AWS Lambda-specific extensions and helpers for hosting Alexa skills using MediatR and System.Text.Json. Includes:

- `LambdaHostExtensions.RunAlexaSkill<T>()` entry point
- `AlexaSkillFunction` base class for DI setup
- OpenTelemetry and Serilog-friendly integration

## ✅ Features

- Minimal setup to run Alexa handlers in AWS Lambda
- Handles serialization, logging, dependency injection

## 🚀 Getting Started

Install the package:

```bash
dotnet add package AlexaVoxCraft.MediatR.Lambda
```

Create a Lambda function:

```csharp
public sealed class MySkillFunction : AlexaSkillFunction
{
    protected override void Init(IHostBuilder builder)
    {
        builder.UseHandler<LambdaHandler, SkillRequest, SkillResponse>()
               .ConfigureServices((ctx, services) =>
               {
                   services.AddSkillMediator(ctx.Configuration, cfg =>
                   {
                       cfg.RegisterServicesFromAssemblyContaining<MySkillFunction>();
                   });
               });
    }
}
```

## 📄 License

Apache-2.0
