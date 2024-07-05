using System.Text.RegularExpressions;

public static partial class GherkinPattern
{
    [GeneratedRegex("^\\s*Feature\\s*:")]
    public static partial Regex Feature();

    [GeneratedRegex("^\\s*Scenario\\s*(Outline){0,1}\\s*:")]
    public static partial Regex Scenario();

    [GeneratedRegex("^\\s*Background\\s*:")]
    public static partial Regex Background();

    [GeneratedRegex("^\\s*Given\\s+")]
    public static partial Regex Given();

    [GeneratedRegex("^\\s*When\\s+")]
    public static partial Regex When();

    [GeneratedRegex("^\\s*Then\\s+")]
    public static partial Regex Then();

    [GeneratedRegex("^\\s*Examples\\s*:")]
    public static partial Regex Examples();

    [GeneratedRegex("^\\s*@\\S+")]
    public static partial Regex Tags();
}
