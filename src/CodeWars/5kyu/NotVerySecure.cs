using System.Text.RegularExpressions;

namespace CodeWars._5kyu;

public static partial class NotVerySecure
{
    private static readonly Regex AlphanumericRegex = CreateAlphanumericRegex();
    
    public static bool Alphanumeric(string str) => AlphanumericRegex.IsMatch(str);
    
    [GeneratedRegex(@"^[a-zA-Z0-9]+$", RegexOptions.Compiled)]
    private static partial Regex CreateAlphanumericRegex();
}