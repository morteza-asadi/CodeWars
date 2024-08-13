namespace CodeWars._4kyu;

public static class NumberOfProperFractions
{
    public static long ProperFractions(long n)
    {
        if (n == 1)
            return 0;

        var result = n;
        for (var p = 2; p * p <= n; p++)
        {
            if (n % p != 0) continue;
            while (n % p == 0)
                n /= p;
            result -= result / p;
        }

        if (n > 1)
            result -= result / n;
        
        return result;
    }
}