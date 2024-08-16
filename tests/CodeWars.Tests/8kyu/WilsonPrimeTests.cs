using CodeWars._8kyu;
using FluentAssertions;

namespace CodeWars.Tests._8kyu;

public class WilsonPrimeTests
{
    [Theory]
    [InlineData(5, true)]
    [InlineData(13, true)]
    [InlineData(563, true)]
    [InlineData(7, false)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    public void AmIWilson_GivenPrimeNumber_ShouldReturnCorrectWilsonPrimeStatus(int input, bool expected)
    {
        // Act
        var result = WilsonPrime.AmIWilson(input);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void AmIWilson_NonPrimeNumber_ShouldReturnFalse()
    {
        // Arrange
        const int input = 4;

        // Act
        var result = WilsonPrime.AmIWilson(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void AmIWilson_SmallestPrimeNumber_ShouldReturnFalse()
    {
        // Arrange
        const int input = 2;

        // Act
        var result = WilsonPrime.AmIWilson(input);

        // Assert
        result.Should().BeFalse();
    }
}