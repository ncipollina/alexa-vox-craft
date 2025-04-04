using System;
using System.Collections.Generic;
using System.Text.Json;
using AlexaVoxCraft.Model.Apl.Commands;
using AlexaVoxCraft.Model.Response.Converters;

namespace AlexaVoxCraft.Model.Apl.JsonConverter;

public class APLCommandConverter : BasePolymorphicConverter<APLCommand>
{
    private static Dictionary<string, Type> _derivedTypes = new()
    {
        {nameof(Idle), typeof(Idle)},
        {nameof(Sequential), typeof(Sequential)},
        {nameof(Parallel), typeof(Parallel)},
        {nameof(SendEvent), typeof(SendEvent)},
        {nameof(SpeakItem), typeof(SpeakItem)},
        {nameof(SpeakList), typeof(SpeakList)},
        {nameof(Scroll), typeof(Scroll)},
        {nameof(ScrollToComponent), typeof(ScrollToComponent)},
        {nameof(ScrollToIndex), typeof(ScrollToIndex)},
        {nameof(SetPage), typeof(SetPage)},
        {nameof(AutoPage), typeof(AutoPage)},
        {nameof(PlayMedia), typeof(PlayMedia)},
        {nameof(ControlMedia), typeof(ControlMedia)},
        {nameof(SetValue), typeof(SetValue)},
        {nameof(AnimateItem),typeof(AnimateItem) },
        {nameof(OpenURL),typeof(OpenURL) },
        {nameof(SetFocus),typeof(SetFocus) },
        {nameof(ClearFocus),typeof(ClearFocus) },
        {nameof(Select),typeof(Select) },
        {nameof(Finish),typeof(Finish) },
        {nameof(Reinflate),typeof(Reinflate) },
        {nameof(InsertItem), typeof(InsertItem)},
        {nameof(RemoveItem), typeof(RemoveItem)}
    };
    
    protected override IDictionary<string, Type> DerivedTypes => _derivedTypes;
    public override Type? DefaultType => typeof(CustomCommand);
}