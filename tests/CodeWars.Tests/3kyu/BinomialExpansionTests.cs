using CodeWars._3kyu;
using FluentAssertions;

namespace CodeWars.Tests._3kyu;

public class BinomialExpansionTests
{
    [Theory]
    [InlineData("(x+1)^0", "1")]
    [InlineData("(x+1)^1", "x+1")]
    [InlineData("(x+1)^2", "x^2+2x+1")]
    public void Expand_PositiveB_ShouldReturnCorrectExpansion(string input, string expected)
    {
        // Act
        var result = BinomialExpansion.Expand(input);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("(x-1)^0", "1")]
    [InlineData("(x-1)^1", "x-1")]
    [InlineData("(x-1)^2", "x^2-2x+1")]
    public void Expand_NegativeB_ShouldReturnCorrectExpansion(string input, string expected)
    {
        // Act
        var result = BinomialExpansion.Expand(input);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("(5m+3)^4", "625m^4+1500m^3+1350m^2+540m+81")]
    [InlineData("(2x-3)^3", "8x^3-36x^2+54x-27")]
    [InlineData("(7x-7)^0", "1")]
    public void Expand_PositiveA_ShouldHandleComplexExpressions(string input, string expected)
    {
        // Act
        var result = BinomialExpansion.Expand(input);

        // Assert
        result.Should().Be(expected, $"because the expansion of {input} should be correct");
    }

    [Theory]
    [InlineData("(-5m+3)^4", "625m^4-1500m^3+1350m^2-540m+81")]
    [InlineData("(-2k-3)^3", "-8k^3-36k^2-54k-27")]
    [InlineData("(-7x-7)^0", "1")]
    public void Expand_NegativeA_ShouldHandleComplexExpressions(string input, string expected)
    {
        // Act
        var result = BinomialExpansion.Expand(input);

        // Assert
        result.Should().Be(expected, $"because the expansion of {input} should be correct");
    }
}