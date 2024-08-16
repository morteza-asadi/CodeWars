using System.Numerics;

namespace CodeWars._8kyu;

public static class WilsonPrime
{
    public static bool AmIWilson(int p)
    {
        if (p < 2)
        {
            return false; // There are no primes less than 2
        }

        // Calculate (P-1)!
        var factorial = Factorial(p - 1);

        // Check the condition (P-1)! + 1
        var condition = factorial + 1;

        // Check if (P-1)! + 1 is divisible by P*P
        return condition % (p * p) == 0;
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (var i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}