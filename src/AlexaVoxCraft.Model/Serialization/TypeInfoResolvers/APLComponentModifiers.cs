using System.Text.Json.Serialization.Metadata;
using AlexaVoxCraft.Model.Responses.Apl;
using AlexaVoxCraft.Model.Responses.Apl.Components;
using AlexaVoxCraft.Model.Responses.Apl.Gestures;

namespace AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;

public class APLComponentModifiers
{
    public static void NormalizePropertyNames(JsonTypeInfo jsonTypeInfo)
    {
        if (jsonTypeInfo.Type == typeof(Container))
        {
            var itemProperty = jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "item");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemProperty.Set = (obj, val) =>
            {
                Container container = (Container)obj;
                APLValue<IEnumerable<APLComponent>> items = (APLValue<IEnumerable<APLComponent>>)val;
                container.Items = items;
            };

            jsonTypeInfo.Properties.Add(itemProperty);
        }
        else if (jsonTypeInfo.Type == typeof(SwipeAway))
        {
            var itemsProperty =
                jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "items");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemsProperty.Set = (obj, val) =>
            {
                SwipeAway swipeAway = (SwipeAway)obj;
                APLValue<IEnumerable<APLComponent>> item = (APLValue<IEnumerable<APLComponent>>)val;
                swipeAway.Item = item;
            };

            jsonTypeInfo.Properties.Add(itemsProperty);
        }
        else if (jsonTypeInfo.Type == typeof(Frame))
        {
            var itemsProperty =
                jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "items");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemsProperty.Set = (obj, val) =>
            {
                Frame swipeAway = (Frame)obj;
                APLValue<IEnumerable<APLComponent>> item = (APLValue<IEnumerable<APLComponent>>)val;
                swipeAway.Item = item;
            };

            jsonTypeInfo.Properties.Add(itemsProperty);
        }
        else if (jsonTypeInfo.Type == typeof(TouchWrapper))
        {
            var itemsProperty =
                jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "items");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemsProperty.Set = (obj, val) =>
            {
                TouchWrapper swipeAway = (TouchWrapper)obj;
                APLValue<IEnumerable<APLComponent>> item = (APLValue<IEnumerable<APLComponent>>)val;
                swipeAway.Item = item;
            };

            jsonTypeInfo.Properties.Add(itemsProperty);
        }
        else if (jsonTypeInfo.Type == typeof(GridSequence))
        {
            var itemProperty = jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "item");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemProperty.Set = (obj, val) =>
            {
                GridSequence gridSequence = (GridSequence)obj;
                APLValue<IEnumerable<APLComponent>> items = (APLValue<IEnumerable<APLComponent>>)val;
                gridSequence.Items = items;
            };

            jsonTypeInfo.Properties.Add(itemProperty);
            
            var childHeight = jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "childHeight");
            // We only want the set property as if we implement the get, it will write "childHeights" and "childHeight" in the json output
            childHeight.Set = (obj, val) =>
            {
                GridSequence gridSequence = (GridSequence)obj;
                APLValue<IEnumerable<APLDimensionValue>> heights = (APLValue<IEnumerable<APLDimensionValue>>)val;
                gridSequence.ChildHeights = heights;
            };

            jsonTypeInfo.Properties.Add(childHeight);

            var childWidth = jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "childWidth");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            childWidth.Set = (obj, val) =>
            {
                GridSequence gridSequence = (GridSequence)obj;
                APLValue<IEnumerable<APLDimensionValue>> widths = (APLValue<IEnumerable<APLDimensionValue>>)val;
                gridSequence.ChildWidths = widths;
            };

            jsonTypeInfo.Properties.Add(childWidth);
        }
        else if (jsonTypeInfo.Type == typeof(Pager))
        {
            var itemProperty = jsonTypeInfo.CreateJsonPropertyInfo(typeof(APLValue<IEnumerable<APLComponent>>), "item");
            // We only want the set property as if we implement the get, it will write "items" and "item" in the json output
            itemProperty.Set = (obj, val) =>
            {
                Pager pager = (Pager)obj;
                APLValue<IEnumerable<APLComponent>> items = (APLValue<IEnumerable<APLComponent>>)val;
                pager.Items = items;
            };

            jsonTypeInfo.Properties.Add(itemProperty);
        }
    }
}