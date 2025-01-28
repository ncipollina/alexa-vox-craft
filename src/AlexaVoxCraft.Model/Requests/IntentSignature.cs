using System.Text.RegularExpressions;

namespace AlexaVoxCraft.Model.Requests;

public sealed class IntentSignature
{
    public string FullName { get; }
    public string Namespace { get; private set; }
    public string Action { get; private set; }
    public System.Collections.ObjectModel.ReadOnlyDictionary<string, IntentProperty> Properties { get; private set; }

    private static readonly Regex PropertyFinder = new Regex(@"(\w+?)@(\w+?)\b(\[(\w+)\])*", RegexOptions.Compiled);

#pragma warning disable CS8618, CS9264
    private IntentSignature(string fullName)
#pragma warning restore CS8618, CS9264
    {
        FullName = fullName;
    }

    public static implicit operator IntentSignature(string action)
    {
        return Parse(action);
    }

    public override int GetHashCode()
    {
        return FullName.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj switch
        {
            string s when !string.IsNullOrWhiteSpace(s) => FullName.Equals(obj),
            IntentSignature signature => FullName.Equals(signature.FullName),
            // ReSharper disable once BaseObjectEqualsIsObjectEquals
            _ => base.Equals(obj)
        };
    }

    public static IntentSignature Parse(string action)
    {
        var intentName = new IntentSignature(action);
        Parse(action.Trim(), intentName);
        return intentName;
    }

    private static void Parse(string action, IntentSignature name)
    {
        if (action.Contains('<') && action.EndsWith('>'))
        {
            ParseComplex(action, name);
        }
        else
        {
            ParseSimple(action, name);
        }
    }

    private static void ParseSimple(string action, IntentSignature name)
    {
        var namespacePoint = action.LastIndexOf('.');

        if (namespacePoint == -1)
        {
            name.Action = action;
            return;
        }

        name.Namespace = action[..namespacePoint];
        name.Action = action[(namespacePoint + 1)..];
    }

    private static void ParseComplex(string action, IntentSignature name)
    {
        var propertyPoint = action.IndexOf('<');
        ParseSimple(action[..propertyPoint],name);

        var propertyPiece = action.Substring(propertyPoint+1, action.Length - (propertyPoint+2));

        IDictionary<string, IntentProperty> propertyDictionary = new Dictionary<string, IntentProperty>();

        foreach (Match match in PropertyFinder.Matches(propertyPiece))
        {
            propertyDictionary.Add(
                match.Groups[1].Value,
                new IntentProperty(match.Groups[2].Value,match.Groups[4].Value)
            );
        }

        name.Properties = new System.Collections.ObjectModel.ReadOnlyDictionary<string, IntentProperty>(propertyDictionary);
    }
}

public record IntentProperty(string Entity, string Property);
