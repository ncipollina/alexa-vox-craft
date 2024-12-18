using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using AlexaVoxCraft.Model.Requests.Apl;
using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Apl.DataSources;
using AlexaVoxCraft.Model.Responses.Apl.Directives;
using AlexaVoxCraft.Model.Responses.Apl.Filters;
using AlexaVoxCraft.Model.Responses.Apl.Gestures;
using AlexaVoxCraft.Model.Responses.Directives;

namespace AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;

public partial class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
{
    public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        var jsonTypeInfo = base.GetTypeInfo(type, options);

        if (jsonTypeInfo.Type == typeof(RequestType))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in RequestTypeDerivedTypes)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(Card))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in CardDerivedTypes)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(Payload))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "@type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in PayloadDerivedTypes)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(OutputSpeech))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in OuptputSpeechDerivedTypes)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(Directive))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in DirectiveDervicedTypes)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(ViewPort))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in ViewportDirectives)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(DataStoreCommand))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in DataStoreCommandDirectives)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(APLDocumentReference))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
            };
            foreach (var derivedType in DocumentDirectives)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(ImageFilter))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToBaseType,
            };
            foreach (var derivedType in ImageFilterDirectives)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }
        else if (jsonTypeInfo.Type == typeof(APLGesture))
        {
            jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "type",
                IgnoreUnrecognizedTypeDiscriminators = true,
                UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToBaseType,
            };
            foreach (var derivedType in APLGestureDirectives)
            {
                jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);
            }
        }

        return jsonTypeInfo;
    }

    public static IList<JsonDerivedType> RequestTypeDerivedTypes = new List<JsonDerivedType>
    {
        new(typeof(LaunchRequest), nameof(LaunchRequest)),
        new(typeof(IntentRequest), typeDiscriminator: nameof(IntentRequest)),
        new(typeof(SessionEndedRequest), typeDiscriminator: nameof(SessionEndedRequest)),
        new(typeof(CanFulfillIntentRequest),
            typeDiscriminator: nameof(CanFulfillIntentRequest)),
        new(typeof(LoadTokenListDataRequest), LoadTokenListDataRequest.RequestType),
        new(typeof(LoadIndexListDataRequest), LoadIndexListDataRequest.RequestType),
        new(typeof(RuntimeErrorRequest), RuntimeErrorRequest.RequestType),
        new(typeof(UserEventRequest), UserEventRequest.RequestType),
        new(typeof(DataStoreErrorRequest), DataStoreErrorRequest.RequestType),
        new(typeof(UsagesInstalledRequest), UsagesInstalledRequest.RequestType),
        new(typeof(UsagesRemovedRequest), UsagesRemovedRequest.RequestType),
        new(typeof(UsagesUpdateRequest), UsagesUpdateRequest.RequestType),
        new(typeof(InstallationErrorRequest), InstallationErrorRequest.RequestType)
    };

    public static IList<JsonDerivedType> CardDerivedTypes = new List<JsonDerivedType>
    {
        new(typeof(SimpleCard), typeDiscriminator: "Simple"),
        new(typeof(AskForPermissionsConsentCard), typeDiscriminator: "AskForPermissionsConsent"),
        new(typeof(LinkAccountCard), typeDiscriminator: "LinkAccount"),
        new(typeof(StandardCard), typeDiscriminator: "Standard")
    };

    public static IList<JsonDerivedType> PayloadDerivedTypes = new List<JsonDerivedType>
    {
        new(typeof(AskForPermissionPayload), typeDiscriminator: "AskForPermissionsConsentRequest")
    };

    public static IList<JsonDerivedType> OuptputSpeechDerivedTypes = new List<JsonDerivedType>
    {
        new(typeof(PlainTextOutputSpeech), typeDiscriminator: "PlainText"),
        new(typeof(SsmlOutputSpeech), typeDiscriminator: "SSML")
    };

    public static IList<JsonDerivedType> DirectiveDervicedTypes = new List<JsonDerivedType>
    {
        new(typeof(AudioPlayerPlayDirective), typeDiscriminator: "AudioPlayer.Play"),
        new(typeof(ClearQueueDirective), typeDiscriminator: "AudioPlayer.ClearQueue"),
        new(typeof(CompleteTaskDirective), typeDiscriminator: "Tasks.CompleteTask"),
        new(typeof(AskForPermissionsDirective), typeDiscriminator: "Connections.SendRequest"),
        new(typeof(DialogConfirmIntent), typeDiscriminator: "Dialog.ConfirmIntent"),
        new(typeof(DialogConfirmSlot), typeDiscriminator: "Dialog.ConfirmSlot"),
        new(typeof(DialogDelegate), typeDiscriminator: "Dialog.Delegate"),
        new(typeof(DialogElicitSlot), typeDiscriminator: "Dialog.ElicitSlot"),
        new(typeof(DialogUpdateDynamicEntities), typeDiscriminator: "Dialog.UpdateDynamicEntities"),
        new(typeof(HintDirective), typeDiscriminator: "Hint"),
        new(typeof(VideoAppDirective), typeDiscriminator: "VideoApp.Launch"),
        new(typeof(StartConnectionDirective), typeDiscriminator: "Connections.StartConnection"),
        new(typeof(StopDirective), typeDiscriminator: "AudioPlayer.Stop"),
        new(typeof(APLRenderDocumentDirective), APLRenderDocumentDirective.DirectiveType),
        new(typeof(APLARenderDocumentDirective), APLARenderDocumentDirective.DirectiveType),
        new(typeof(APLTRenderDocumentDirective), APLTRenderDocumentDirective.DirectiveType),
        new(typeof(ExecuteCommandsDirective), ExecuteCommandsDirective.DirectiveType)
    };

    public static IList<JsonDerivedType> ViewportDirectives = new List<JsonDerivedType>
    {
        new(typeof(APLViewport), typeDiscriminator: "APL"),
        new(typeof(APLTViewport), typeDiscriminator: "APLT")
    };

    public static IList<JsonDerivedType> DataStoreCommandDirectives = new List<JsonDerivedType>
    {
        new(typeof(PutNamespaceDataStoreCommand), PutNamespaceDataStoreCommand.DataStoreCommandType),
        new(typeof(PutObjectDataStoreCommand), PutObjectDataStoreCommand.DataStoreCommandType),
        new(typeof(RemoveNamespaceDataStoreCommand), RemoveNamespaceDataStoreCommand.DataStoreCommandType),
        new(typeof(RemoveObjectDataStoreCommand), RemoveObjectDataStoreCommand.DataStoreCommandType),
        new(typeof(ClearDataStoreCommand), ClearDataStoreCommand.DataStoreCommandType)
    };

    public static IList<JsonDerivedType> DocumentDirectives = new List<JsonDerivedType>()
    {
        new(typeof(APLDocument), APLDocument.DocumentType)
    };

}