using AlexaVoxCraft.Model.Apl.DataStore;
using AlexaVoxCraft.Model.Apl.DataStore.PackageManager;
using AlexaVoxCraft.Model.Apl.JsonConverter;

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
    }
}