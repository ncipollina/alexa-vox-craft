using AlexaVoxCraft.Model.Responses.Apl.DataSources;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLDataSourceConverter : BasePolymorphicConverter<APLDataSource>
{
    public override string TypeDiscriminatorPropertyName => "type";

    public override IDictionary<string, Type> DerivedTypes => new Dictionary<string, Type>
    {
        { ObjectDataSource.DataSourceType, typeof(ObjectDataSource) },
        { DynamicIndexList.DataSourceType, typeof(DynamicIndexList) },
        { DynamicTokenList.DataSourceType, typeof(DynamicTokenList) },
        { ListDataSource.DataSourceType, typeof(ListDataSource) }
    };
    public override Type? DefaultType => typeof(KeyValueDataSource);
}