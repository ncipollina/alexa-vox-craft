using AlexaVoxCraft.Model.Responses.Apl.Components;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLComponentConverter : BasePolymorphicConverter<APLComponent>
{
    public override string TypeDiscriminatorPropertyName => "type";
    public override IDictionary<string, Type> DerivedTypes => new Dictionary<string, Type>
    {
        { nameof(AlexaRadioButton), typeof(AlexaRadioButton) },
        { nameof(Container), typeof(Container) },
        { nameof(Image), typeof(Image) },
        { nameof(Text), typeof(Text) },
        { nameof(ScrollView), typeof(ScrollView) },
        { nameof(AlexaSlider), typeof(AlexaSlider) },
        { nameof(AlexaFooter), typeof(AlexaFooter) },
        { nameof(Video), typeof(Video) },
        { nameof(TimeText), typeof(TimeText) },
        { nameof(TouchWrapper), typeof(TouchWrapper) },
        { nameof(AlexaIconButton), typeof(AlexaIconButton) },
        { nameof(AlexaImageListItem), typeof(AlexaImageListItem) },
        { nameof(AlexaRating), typeof(AlexaRating) },
        { nameof(AlexaImageList), typeof(AlexaImageList) },
        { nameof(AlexaLists), typeof(AlexaLists) },
        { nameof(AlexaPaginatedList), typeof(AlexaPaginatedList) },
        { nameof(Frame), typeof(Frame) },
        { nameof(AlexaProgressBar), typeof(AlexaProgressBar) },
        { nameof(AlexaProgressBarRadial), typeof(AlexaProgressBarRadial) },
        { nameof(AlexaProgressDots), typeof(AlexaProgressDots) },
        { nameof(AlexaSliderRadial), typeof(AlexaSliderRadial) },
        { nameof(AlexaDetail), typeof(AlexaDetail) },
        { nameof(AlexaGridList), typeof(AlexaGridList) },
        { nameof(EditText), typeof(EditText) },
        { nameof(AlexaSwipeToAction), typeof(AlexaSwipeToAction) },
        { nameof(AlexaCheckbox), typeof(AlexaCheckbox) },
        { nameof(AlexaSwitch), typeof(AlexaSwitch) },
        { nameof(GridSequence), typeof(GridSequence) },
        { nameof(Pager), typeof(Pager) },
        { nameof(AlexaIcon), typeof(AlexaIcon) },
        { nameof(AlexaCard), typeof(AlexaCard) },
        { nameof(AlexaImageCaption), typeof(AlexaImageCaption) },
        { nameof(AlexaPhoto), typeof(AlexaPhoto) },
        { nameof(AlexaTextWrapping), typeof(AlexaTextWrapping) }
    };

    public override Type? DefaultType => typeof(CustomComponent);
}