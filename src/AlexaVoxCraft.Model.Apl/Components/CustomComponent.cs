namespace AlexaVoxCraft.Model.Apl.Components;

public class CustomComponent : APLComponent
{
    public CustomComponent(string type)
    {
        Type = type;
    }

    public override string Type { get; }
}