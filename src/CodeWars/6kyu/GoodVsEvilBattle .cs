namespace CodeWars._6kyu;

public static class GoodVsEvilBattle
{
    public static string GoodVsEvil(string good, string evil)
    {
        // Define worth for each race
        int[] goodWorth = { 1, 2, 3, 3, 4, 10 };
        int[] evilWorth = { 1, 2, 2, 2, 3, 5, 10 };

        // Parse the input strings into arrays of integers
        int[] goodCounts = Array.ConvertAll(good.Split(' '), int.Parse);
        int[] evilCounts = Array.ConvertAll(evil.Split(' '), int.Parse);

        // Calculate total worth for the good side
        int goodTotal = 0;
        for (int i = 0; i < goodWorth.Length; i++)
        {
            goodTotal += goodCounts[i] * goodWorth[i];
        }

        // Calculate total worth for the evil side
        int evilTotal = 0;
        for (int i = 0; i < evilWorth.Length; i++)
        {
            evilTotal += evilCounts[i] * evilWorth[i];
        }

        // Determine the result
        if (goodTotal > evilTotal)
        {
            return "Battle Result: Good triumphs over Evil";
        }
        else if (evilTotal > goodTotal)
        {
            return "Battle Result: Evil eradicates all trace of Good";
        }
        else
        {
            return "Battle Result: No victor on this battle field";
        }
    }
}