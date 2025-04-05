using AlexaVoxCraft.Model.Apl.Audio;
using AlexaVoxCraft.Model.Apl.Commands;
using AlexaVoxCraft.Model.Apl.DataSources;
using AlexaVoxCraft.Model.Apl.DataStore;
using AlexaVoxCraft.Model.Apl.DataStore.PackageManager;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Apl.VectorGraphics;

namespace AlexaVoxCraft.Model.Apl;

public static class APLSupport
{
    public static void Add()
    {
        RenderDocumentDirective.AddSupport();
        ExecuteCommandsDirective.AddSupport();
        SendIndexListDataDirective.AddSupport();
        UpdateIndexListDataDirective.AddSupport();
        UserEventRequestHandler.AddToRequestConverter();
        LoadIndexListDataRequestHandler.AddToRequestConverter();
        LoadTokenListDataRequestHandler.AddToRequestConverter();
        RuntimeErrorRequestHandler.AddToRequestConverter();
        UsagesInstalledRequestHandler.AddToRequestConverter();
        UsagesRemovedRequestHandler.AddToRequestConverter();
        UpdateRequestHandler.AddToRequestConverter();
        InstallationErrorHandler.AddToRequestConverter();
        DataStoreErrorHandler.AddToRequestConverter();
        FixedDecimalJsonConverter.AddSupport();
        // Add support for models
        Parameter.AddSupport();
        CommandDefinition.AddSupport();
        Select.AddSupport();
        InsertItem.AddSupport();
        AudioLayout.AddSupport();
        Audio.Audio.AddSupport();
        APLAMultiChildComponent.AddSupport();
        Sequencer.AddSupport();
        Selector.AddSupport();
        DynamicIndexList.AddSupport();
        DynamicTokenList.AddSupport();
        Mixer.AddSupport();
        Style.AddSupport();
        AVG.AddSupport();
        APLDocument.AddSupport();
        APLKeyboardHandler.AddSupport();
        Import.AddSupport();
    }
}