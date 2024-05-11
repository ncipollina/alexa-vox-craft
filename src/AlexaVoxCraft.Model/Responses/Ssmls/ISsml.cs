using System.Xml.Linq;

namespace AlexaVoxCraft.Model.Responses.Ssmls;

public interface ISsml
{
    XNode ToXml();
}