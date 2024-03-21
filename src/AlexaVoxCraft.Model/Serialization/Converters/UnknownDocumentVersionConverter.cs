using System.Text.Json;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class UnknownDocumentVersionConverter : JsonStringEnumConverter<APLDocumentVersion>
{
    public UnknownDocumentVersionConverter() : base(namingPolicy: ResolveNamingPolicy())
    {
    }

    private static JsonNamingPolicy? ResolveNamingPolicy()
    {
        return new EnumMemberNamingPolicy();
    }
    
    private sealed class EnumMemberNamingPolicy() : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToEnumString();
    }

}
