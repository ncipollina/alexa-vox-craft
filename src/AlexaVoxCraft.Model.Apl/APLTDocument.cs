namespace AlexaVoxCraft.Model.Apl;

public class APLTDocument : APLDocumentBase
{
    public override string Type => "APLT";

    public APLTDocument():base(APLDocumentVersion.V1)
    {

    }
}