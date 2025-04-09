# AlexaVoxCraft.Model.Apl

Provides comprehensive model support for Alexa Presentation Language (APL). This package includes:

- Strongly typed models for APL documents, commands, datasources, layouts, and more
- Converters to support polymorphic deserialization (commands, components, etc.)
- Enum serialization support for `[EnumMember(Value = ...)]`

## ✅ Features

- System.Text.Json compatible APL types
- Easily extendable for custom APL components

## 🚀 Getting Started

Install the package:

```bash
dotnet add package AlexaVoxCraft.Model.Apl
```

Deserialize incoming APL UserEvents:

```csharp
if (request.Request is UserEvent userEvent)
{
    var args = userEvent.Arguments;
}
```

## 📄 License

Apache-2.0
