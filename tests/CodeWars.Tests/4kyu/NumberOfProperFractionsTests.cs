using CodeWars._4kyu;
using FluentAssertions;

namespace CodeWars.Tests._4kyu;

public class NumberOfProperFractionsTests
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(5, 4)]
    [InlineData(15, 8)]
    [InlineData(25, 20)]
    [InlineData(9, 6)]
    [InlineData(100, 40)]
    [InlineData(30, 8)]
    public void ProperFractions_GivenDenominator_ReturnsNumberOfProperFractions(long denominator, long expectedCount)
    {
        // Act
        var result = NumberOfProperFractions.ProperFractions(denominator);

        // Assert
        result.Should().Be(expectedCount);
    }

    [Fact]
    public void ProperFractions_DenominatorIsLargeNumber_ReturnsCorrectCount()
    {
        // Arrange
        const long denominator = 1_000_000; // A large number to test efficiency
        const long expectedCount = 400_000; // Known result for φ(1,000,000)

        // Act
        var result = NumberOfProperFractions.ProperFractions(denominator);

        // Assert
        result.Should().Be(expectedCount);
    }
}