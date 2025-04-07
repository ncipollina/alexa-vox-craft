using AlexaVoxCraft.Model.Apl.Audio;
using AlexaVoxCraft.Model.Apl.Commands;
using AlexaVoxCraft.Model.Apl.Components;
using AlexaVoxCraft.Model.Apl.DataSources;
using AlexaVoxCraft.Model.Apl.DataStore;
using AlexaVoxCraft.Model.Apl.DataStore.PackageManager;
using AlexaVoxCraft.Model.Apl.Gestures;
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
        // Add global converters
        ObjectConverter.AddSupport();
        // Add support for models
        Parameter.RegisterTypeInfo<Parameter>();
        CommandDefinition.RegisterTypeInfo<CommandDefinition>();
        Select.AddSupport();
        InsertItem.RegisterTypeInfo<InsertItem>();
        AudioLayout.AddSupport();
        Audio.Audio.AddSupport();
        APLAMultiChildComponent.AddSupport();
        Sequencer.AddSupport();
        Selector.AddSupport();
        DynamicIndexList.RegisterTypeInfo<DynamicIndexList>();
        DynamicTokenList.RegisterTypeInfo<DynamicTokenList>();
        Mixer.AddSupport();
        Style.RegisterTypeInfo<Style>();
        AVG.AddSupport();
        APLDocument.RegisterTypeInfo<APLDocument>();
        APLKeyboardHandler.AddSupport();
        Import.RegisterTypeInfo<Import>();
        Sequential.AddSupport();
        Parallel.AddSupport();
        APLDocumentBase.RegisterTypeInfo<APLDocumentBase>();
        APLTDocument.AddSupport();
        Layout.AddSupport();
        APLDocumentEnvironment.AddSupport();
        APLComponentBase.RegisterTypeInfo<APLComponentBase>();
        APLComponent.RegisterTypeInfo<APLComponent>();
        Container.RegisterTypeInfo<Container>();
        Image.RegisterTypeInfo<Image>();
        TextBase.RegisterTypeInfo<TextBase>();
        Text.RegisterTypeInfo<Text>();
        OpenURL.RegisterTypeInfo<OpenURL>();
        ActionableComponent.RegisterTypeInfo<ActionableComponent>();
        ScrollView.RegisterTypeInfo<ScrollView>();
        AnimateItem.RegisterTypeInfo<AnimateItem>();
        Binding.RegisterTypeInfo<Binding>();
        Video.RegisterTypeInfo<Video>();
        VideoSource.RegisterTypeInfo<VideoSource>();
        TimeText.RegisterTypeInfo<TimeText>();
        TouchComponent.RegisterTypeInfo<TouchComponent>();
        TouchWrapper.RegisterTypeInfo<TouchWrapper>();
        DoublePress.RegisterTypeInfo<DoublePress>();
        LongPress.RegisterTypeInfo<LongPress>();
        SwipeAway.RegisterTypeInfo<SwipeAway>();
        Tap.RegisterTypeInfo<Tap>();
        APLAction.RegisterTypeInfo<APLAction>();
        AlexaIconButton.RegisterTypeInfo<AlexaIconButton>();
        AlexaListItem.RegisterTypeInfo<AlexaListItem>();
        AlexaPaginatedListItem.RegisterTypeInfo<AlexaPaginatedListItem>();
        AlexaImageListItem.RegisterTypeInfo<AlexaImageListItem>();
        AlexaRating.RegisterTypeInfo<AlexaRating>();
        ResponsiveTemplate.RegisterTypeInfo<ResponsiveTemplate>();
        AlexaImageListBase.RegisterTypeInfo<AlexaImageListBase>();
        AlexaImageList.RegisterTypeInfo<AlexaImageList>();
        AlexaLists.RegisterTypeInfo<AlexaLists>();
        AlexaPaginatedList.RegisterTypeInfo<AlexaPaginatedList>();
        TickHandler.RegisterTypeInfo<TickHandler>();
        Frame.RegisterTypeInfo<Frame>();
        AlexaProgressBarBase.RegisterTypeInfo<AlexaProgressBar>();
        AlexaProgressBar.RegisterTypeInfo<AlexaProgressBar>();
        AlexaProgressBarRadial.RegisterTypeInfo<AlexaProgressBarRadial>();
        AlexaProgressDots.RegisterTypeInfo<AlexaProgressDots>();
        AlexaSliderBase.RegisterTypeInfo<AlexaSlider>();
        AlexaSlider.RegisterTypeInfo<AlexaSlider>();
        AlexaSliderRadial.RegisterTypeInfo<AlexaSliderRadial>();
        AlexaDetail.RegisterTypeInfo<AlexaDetail>();
        IngredientListItem.RegisterTypeInfo<IngredientListItem>();
        AlexaGridList.RegisterTypeInfo<AlexaGridList>();
        EditText.RegisterTypeInfo<EditText>();
        AlexaSwipeToAction.RegisterTypeInfo<AlexaSwipeToAction>();
        AlexaRadioButton.RegisterTypeInfo<AlexaRadioButton>();
        AlexaCheckbox.RegisterTypeInfo<AlexaCheckbox>();
        AlexaSwitch.RegisterTypeInfo<AlexaSwitch>();
    }
}