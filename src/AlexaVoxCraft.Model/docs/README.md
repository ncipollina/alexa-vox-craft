# AlexaVoxCraft.Model

This package provides the core Alexa request and response models, fully compatible with `System.Text.Json`. It includes support for:

- Skill request types (LaunchRequest, IntentRequest, etc.)
- Session, context, device, and user metadata
- Response building utilities

## ✅ Features

- Strongly typed model structure for Alexa interactions
- Clean serialization without Newtonsoft.Json
- Designed for use in AWS Lambda or any C# host

## 🚀 Getting Started

Install the package:

```bash
dotnet add package AlexaVoxCraft.Model
```

Deserialize Alexa requests:

```csharp
var request = JsonSerializer.Deserialize<SkillRequest>(json, AlexaJsonOptions.DefaultOptions);
```

## 📄 License

Apache-2.0