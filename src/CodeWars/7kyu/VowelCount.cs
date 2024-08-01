namespace CodeWars._7kyu;
public static class VowelCount
{
    public static int GetVowelCount(string str)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        return str.Count(c => vowels.Contains(c));
    }
}