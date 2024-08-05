namespace CodeWars._5kyu;

public static class FirstNonRepeatingCharacter
{
    public static string FirstNonRepeatingLetter(string s)
    {
        return string.IsNullOrEmpty(s) ? 
            string.Empty : 
            s.GroupBy(char.ToLower)
            .Where(w => w.Count() == 1)
            .Select(w => w.First().ToString())
            .DefaultIfEmpty("")
            .First();
    }
}