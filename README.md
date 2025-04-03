# AlexaVoxCraft

## Package Version

| Package                      | Build Status                                                                                                                                       | Version                                                                                                                   | Downloads                                                                                                                       |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|
| AlexaVoxCraft.MediatR        | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)        | [![NuGet](https://img.shields.io/nuget/v/AlexaVoxCraft.MediatR.svg?color=orange)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR/)                         | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.MediatR.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR/)                         |
| AlexaVoxCraft.MediatR.Lambda | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)        | [![NuGet](https://img.shields.io/nuget/v/AlexaVoxCraft.MediatR.Lambda.svg?color=orange)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR.Lambda/)           | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.MediatR.Lambda.svg)](https://www.nuget.org/packages/AlexaVoxCraft.MediatR.Lambda/)           |
| AlexaVoxCraft.Model          | [![Build](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml/badge.svg)](https://github.com/ncipollina/alexa-vox-craft/actions/workflows/build.yaml)        | [![NuGet](https://img.shields.io/nuget/v/AlexaVoxCraft.Model.svg?color=orange)](https://www.nuget.org/packages/AlexaVoxCraft.Model/)                             | [![NuGet Downloads](https://img.shields.io/nuget/dt/AlexaVoxCraft.Model.svg)](https://www.nuget.org/packages/AlexaVoxCraft.Model/)                             |

## Introduction

AlexaVoxCraft is a .NET library for crafting interactive voice experiences with Amazon Alexa using the VoxCraft framework. This repository provides tools and utilities to develop, deploy, and manage Alexa skills in .NET applications.

### What does "AlexaVoxCraft" mean?

- **Alexa**: Represents the integration with Amazon Alexa, the voice service powering devices like Amazon Echo.
- **VoxCraft**: Signifies the focus on voice-driven interactions, leveraging the VoxCraft framework.

## Packages

### AlexaVoxCraft.Lambda.AspNetCoreServer

The `AlexaVoxCraft.Lambda.AspNetCoreServer` package contains the code to run the skill in an AWS Lambda function with all of the ASP.NET hosting capabilities, including dependency injection, middleware, and the ability to process an Alexa skill request. All you have to provide are your request handlers.

### AlexaVoxCraft.Model

The `AlexaVoxCraft.Model` package contains objects that represent the request and response objects to interface with Alexa custom skills. These models are based on the models defined in [this repository](https://github.com/timheuer/alexa-skills-dotnet), but have been converted to use System.Text.Json for serialization.

## Features

- **Voice Skill Development**: Build interactive voice skills for Amazon Alexa using .NET and VoxCraft.
- **Integration with Amazon Lambda**: Deploy and host your Alexa skills seamlessly with Amazon Lambda hosting using the `AlexaVoxCraft.Lambda.AspNetCoreServer` package.
- **JSON Serialization with System.Text.Json**: Utilize System.Text.Json for efficient JSON serialization, ensuring compatibility and performance.

## Getting Started

Follow these steps to start crafting voice experiences with AlexaVoxCraft:

1. **Installation**: Install the `AlexaVoxCraft.Lambda.AspNetCoreServer` and `AlexaVoxCraft.Model` packages from NuGet.
   ```bash
   dotnet add package AlexaVoxCraft.Lambda.AspNetCoreServer
   dotnet add package AlexaVoxCraft.Model
2. **Development**: Create your Alexa skill logic using the `AlexaVoxCraft.Model` package for request and response objects, and use the `AlexaVoxCraft.Lambda.AspNetCoreServer` package to run the skill in an AWS Lambda function.
3. **Deployment**: Deploy your Alexa skill to Amazon Lambda using the `Amazon.Lambda.AspNetCoreServer` package.
4. **Enjoy**: Interact with your skill using Amazon Alexa devices and explore the possibilities of voice-driven applications!

## Contribution

Contributions are welcome! Feel free to submit issues, feature requests, or pull requests to help improve AlexaVoxCraft.

## License

This project is licensed under the [Apache License 2.0](LICENSE).

<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->
## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ncipollina"><img src="https://avatars.githubusercontent.com/u/1405469?v=4?s=100" width="100px;" alt="Nick Cipollina"/><br /><sub><b>Nick Cipollina</b></sub></a><br /><a href="#content-ncipollina" title="Content">🖋</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!