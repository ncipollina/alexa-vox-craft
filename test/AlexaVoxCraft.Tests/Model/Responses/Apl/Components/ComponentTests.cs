using AlexaVoxCraft.Model.Responses.Apl;
using AlexaVoxCraft.Model.Responses.Apl.Components;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Apl.Components;

public class ComponentTests
{
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/Binding.json")]
    public void Can_Deserialize_Bindings_Json(APLComponent component)
    {
        var text = component.Should().NotBeNull().And.BeOfType<Text>().Subject;
        text.When = APLValue.To<bool?>("${@viewportProfile == @hubLandscapeSmall}");
        text.Bindings.Count().Should().Be(2);

        var first = text.Bindings.First();
        first.Name.Should().Be("foo");
        first.Value.Should().Be("27");

        var second = text.Bindings.Skip(1).First();
        second.Name.Should().Be("bar");
        second.Value.Should().Be("${foo + 23}");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/Video.json")]
    public void Can_Deserialize_Video_Json(APLComponent component)
    {
        var video = component.Should().NotBeNull().And.BeOfType<Video>().Subject;
        Utility.CompareJson(video, "APL/Components/Video.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/ImageFilters.json")]
    public void Can_Deserialize_Image_Json(APLComponent component)
    {
        var image = component.Should().NotBeNull().And.BeOfType<Image>().Subject;
        Utility.CompareJson(image, "APL/Components/ImageFilters.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/TimeText.json")]
    public void Can_Deserialize_TimeText_Json(APLComponent component)
    {
        var timeText = component.Should().NotBeNull().And.BeOfType<TimeText>().Subject;
        Utility.CompareJson(timeText, "APL/Components/TimeText.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/KeyboardTouchWrapper.json")]
    public void Can_Deserialize_TouchWrapper_Json(APLComponent component)
    {
        var touchWrapper = component.Should().NotBeNull().And.BeOfType<TouchWrapper>().Subject;
        Utility.CompareJson(touchWrapper, "APL/Components/KeyboardTouchWrapper.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaIconButton.json")]
    public void Can_Deserialize_AlexaIconButton_Json(APLComponent component)
    {
        var button = component.Should().NotBeNull().And.BeOfType<AlexaIconButton>().Subject;
        Utility.CompareJson(button, "APL/Components/AlexaIconButton.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaImageListItem.json")]
    public void Can_Deserialize_AlexaImageListItem_Json(APLComponent component)
    {
        var imageListItem = component.Should().NotBeNull().And.BeOfType<AlexaImageListItem>().Subject;
        Utility.CompareJson(imageListItem, "APL/Components/AlexaImageListItem.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaLists.json")]
    public void Can_Deserialize_AlexaLists_Json(APLComponent component)
    {
        var lists = component.Should().NotBeNull().And.BeOfType<AlexaLists>().Subject;
        Utility.CompareJson(lists, "APL/Components/AlexaLists.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaPaginatedList.json")]
    public void Can_Deserialize_AlexaPaginatedList_Json(APLComponent component)
    {
        var paginatedList = component.Should().NotBeNull().And.BeOfType<AlexaPaginatedList>().Subject;
        Utility.CompareJson(paginatedList, "APL/Components/AlexaPaginatedList.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/TickHandler.json")]
    public void Can_Deserialize_Container_With_TickHandler_Json(APLComponent component)
    {
        var container = component.Should().NotBeNull().And.BeOfType<Container>().Subject;
        Utility.CompareJson(container, "APL/Components/TickHandler.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaProgressBar.json")]
    public void Can_Deserialize_AlexaProgressBar_Json(APLComponent component)
    {
        var progressBar = component.Should().NotBeNull().And.BeOfType<AlexaProgressBar>().Subject;
        Utility.CompareJson(progressBar, "APL/Components/AlexaProgressBar.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaProgressBarRadial.json")]
    public void Can_Deserialize_Container_With_AlexaProgressBarRadial_Json(APLComponent component)
    {
        var container = component.Should().NotBeNull().And.BeOfType<Container>().Subject;
        Utility.CompareJson(container, "APL/Components/AlexaProgressBarRadial.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaProgressDots.json")]
    public void Can_Deserialize_AlexaProgressDots_Json(APLComponent component)
    {
        var progressDots = component.Should().NotBeNull().And.BeOfType<AlexaProgressDots>().Subject;
        Utility.CompareJson(progressDots, "APL/Components/AlexaProgressDots.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaRating.json")]
    public void Can_Deserialize_AlexaRating_Json(APLComponent component)
    {
        var rating = component.Should().NotBeNull().And.BeOfType<AlexaRating>().Subject;
        Utility.CompareJson(rating, "APL/Components/AlexaRating.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaImageList.json")]
    public void Can_Deserialize_AlexaImageList_Json(APLComponent component)
    {
        var imageList = component.Should().NotBeNull().And.BeOfType<AlexaImageList>().Subject;
        Utility.CompareJson(imageList, "APL/Components/AlexaImageList.json");
    }


    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaRadioButton.json")]
    public void Can_Deserialize_AlexaRadioButton_Json(APLComponent component)
    {
        var alexRadioButton = component.Should().NotBeNull().And.BeOfType<AlexaRadioButton>().Subject;
        Utility.CompareJson(alexRadioButton, "APL/Components/AlexaRadioButton.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaSlider.json")]
    public void Can_Deserialize_AlexaSlider_Json(APLComponent component)
    {
        var alexaSlider = component.Should().NotBeNull().And.BeOfType<AlexaSlider>().Subject;
        Utility.CompareJson(alexaSlider, "APL/Components/AlexaSlider.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaSliderRadial.json")]
    public void Can_Deserialize_Container_With_AlexaSliderRadial_Json(APLComponent component)
    {
        var container = component.Should().NotBeNull().And.BeOfType<Container>().Subject;
        Utility.CompareJson(container, "APL/Components/AlexaSliderRadial.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaDetailRecipe.json")]
    public void Can_Deserialize_AlexaDetail_Recipe_Json(APLComponent component)
    {
        var detail = component.Should().NotBeNull().And.BeOfType<AlexaDetail>().Subject;
        Utility.CompareJson(detail, "APL/Components/AlexaDetailRecipe.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaDetailTv.json")]
    public void Can_Deserialize_AlexaDetail_Tv_Json(APLComponent component)
    {
        var detail = component.Should().NotBeNull().And.BeOfType<AlexaDetail>().Subject;
        Utility.CompareJson(detail, "APL/Components/AlexaDetailTv.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaGridList.json")]
    public void Can_Deserialize_AlexaGridList_Json(APLComponent component)
    {
        var gridList = component.Should().NotBeNull().And.BeOfType<AlexaGridList>().Subject;
        Utility.CompareJson(gridList, "APL/Components/AlexaGridList.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/EditText.json")]
    public void Can_Deserialize_EditText_Json(APLComponent component)
    {
        var editText = component.Should().NotBeNull().And.BeOfType<EditText>().Subject;
        Utility.CompareJson(editText, "APL/Components/EditText.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaSwipeToAction.json")]
    public void Can_Deserialize_AlexaSwipeToAction_Json(APLComponent component)
    {
        var swipeToAction = component.Should().NotBeNull().And.BeOfType<AlexaSwipeToAction>().Subject;
        Utility.CompareJson(swipeToAction, "APL/Components/AlexaSwipeToAction.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaCheckbox.json")]
    public void Can_Deserialize_AlexaCheckbox_Json(APLComponent component)
    {
        var checkbox = component.Should().NotBeNull().And.BeOfType<AlexaCheckbox>().Subject;
        Utility.CompareJson(checkbox, "APL/Components/AlexaCheckbox.json");
    }

    [Theory, ModelAutoData(typeof(Container), "APL/Components/ContainerWithItem.json")]
    public void Can_Deserialize_ContainerWithItem_Json(Container component)
    {
        var container = component.Should().NotBeNull().And.BeOfType<Container>().Subject;
        Utility.CompareJson(container, "APL/Components/ContainerWithItem.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaSwitch.json")]
    public void Can_Deserialize_AlexaSwitch_Json(APLComponent component)
    {
        var alexaSwitch = component.Should().NotBeNull().And.BeOfType<AlexaSwitch>().Subject;
        Utility.CompareJson(alexaSwitch, "APL/Components/AlexaSwitch.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/GridSequence.json")]
    public void Can_Deserialize_GridSequence_Json(APLComponent component)
    {
        var gridSequence = component.Should().NotBeNull().And.BeOfType<GridSequence>().Subject;
        Utility.CompareJson(gridSequence, "APL/Components/GridSequence.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/Pager.json")]
    public void Can_Deserialize_Pager_Json(APLComponent component)
    {
        var pager = component.Should().NotBeNull().And.BeOfType<Pager>().Subject;
        Utility.CompareJson(pager, "APL/Components/Pager.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaIcon.json")]
    public void Can_Deserialize_AlexaIcon_Json(APLComponent component)
    {
        var icon = component.Should().NotBeNull().And.BeOfType<AlexaIcon>().Subject;
        Utility.CompareJson(icon, "APL/Components/AlexaIcon.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaCard.json")]
    public void Can_Deserialize_AlexaCard_Json(APLComponent component)
    {
        var card = component.Should().NotBeNull().And.BeOfType<AlexaCard>().Subject;
        Utility.CompareJson(card, "APL/Components/AlexaCard.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaImageCaption.json")]
    public void Can_Deserialize_AlexaImageCaption_Json(APLComponent component)
    {
        var imageCaption = component.Should().NotBeNull().And.BeOfType<AlexaImageCaption>().Subject;
        Utility.CompareJson(imageCaption, "APL/Components/AlexaImageCaption.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaPhoto.json")]
    public void Can_Deserialize_AlexaPhoto_Json(APLComponent component)
    {
        var photo = component.Should().NotBeNull().And.BeOfType<AlexaPhoto>().Subject;
        Utility.CompareJson(photo, "APL/Components/AlexaPhoto.json");
    }

    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/AlexaTextWrapping.json")]
    public void Can_Deserialize_AlexaTextWrapping_Json(APLComponent component)
    {
        var textWrapping = component.Should().NotBeNull().And.BeOfType<AlexaTextWrapping>().Subject;
        Utility.CompareJson(textWrapping, "APL/Components/AlexaTextWrapping.json");
    }
    
    [Theory, ModelAutoData(typeof(APLComponent), "APL/Components/Frame.json")]
    public void Can_Deserialize_Frame_Json(APLComponent component)
    {
        var frame = component.Should().NotBeNull().And.BeOfType<Frame>().Subject;
        Utility.CompareJson(frame, "APL/Components/Frame.json");
    }
}