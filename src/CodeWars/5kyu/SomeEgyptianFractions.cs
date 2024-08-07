using System.Numerics;

namespace CodeWars._5kyu;

public static class SomeEgyptianFractions
{
    public static string Decompose(string nrStr, string drStr) 
    {
        var numerator = BigInteger.Parse(nrStr);
        var denominator = BigInteger.Parse(drStr);

        if (numerator == 0)
            return "[]";

        var result = new List<string>();

        // Handle whole numbers
        if (numerator >= denominator)
        {
            var wholeNumber = numerator / denominator;
            result.Add(wholeNumber.ToString());
            numerator %= denominator;

            if (numerator == 0)
                return $"[{string.Join(", ", result)}]";
        }

        while (numerator > 0)
        {
            var unitFractionDenominator = (denominator + numerator - 1) / numerator;

            result.Add($"1/{unitFractionDenominator}");

            numerator = numerator * unitFractionDenominator - denominator;
            denominator = denominator * unitFractionDenominator;

            var gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        return $"[{string.Join(", ", result)}]";
    }
}