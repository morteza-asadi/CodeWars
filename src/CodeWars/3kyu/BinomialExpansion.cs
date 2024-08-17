using System.Numerics;
using System.Text.RegularExpressions;

namespace CodeWars._3kyu;

public static partial class BinomialExpansion
{
    private static readonly Regex ExpressionRegex = MyRegex();

    public static string Expand(string expr)
    {
        var match = ExpressionRegex.Match(expr);
        if (!match.Success) return expr;

        var (a, x, b, n) = ParseExpression(match);

        if (n == 0) return "1";

        var terms = CalculateTerms(a, b, n);
        return FormatResult(terms, x, n);
    }

    private static (int a, char x, int b, int n) ParseExpression(Match match)
    {
        var a = ParseCoefficient(match.Groups[1].Value);
        var x = match.Groups[2].Value[0];
        var b = int.Parse(match.Groups[3].Value);
        var n = int.Parse(match.Groups[4].Value);
        return (a, x, b, n);
    }

    private static int ParseCoefficient(string value)
    {
        return string.IsNullOrEmpty(value) ? 1 :
            value == "-" ? -1 :
            int.Parse(value);
    }

    private static BigInteger[] CalculateTerms(int a, int b, int n)
    {
        var terms = new BigInteger[n + 1];
        for (var k = 0; k <= n; k++)
        {
            terms[k] = Combination(n, k) * BigInteger.Pow(a, n - k) * BigInteger.Pow(b, k);
        }

        return terms;
    }

    private static string FormatResult(BigInteger[] terms, char x, int n)
    {
        return string.Join("", terms.Select((term, k) => FormatTerm(term, x, n - k, k)));
    }

    private static string FormatTerm(BigInteger coefficient, char variable, int power, int termIndex)
    {
        if (coefficient == 0) return "";

        var term = "";
        if (coefficient < 0)
        {
            term += "-";
            coefficient = -coefficient;
        }
        else if (termIndex > 0)
        {
            term += "+";
        }

        if (coefficient != 1 || power == 0)
        {
            term += coefficient.ToString();
        }

        if (power > 0)
        {
            term += variable;
            if (power > 1)
            {
                term += "^" + power;
            }
        }

        return term;
    }

    private static BigInteger Combination(int n, int k)
    {
        if (k > n - k) k = n - k;
        BigInteger result = 1;
        for (var i = 1; i <= k; i++)
        {
            result *= n - (k - i);
            result /= i;
        }

        return result;
    }

    [GeneratedRegex(@"\((-?\d*)(\w)([+-]\d+)\)\^(\d+)", RegexOptions.Compiled)]
    private static partial Regex MyRegex();
}