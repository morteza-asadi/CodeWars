using CodeWars._5kyu;
using FluentAssertions;

namespace CodeWars.Tests._5kyu;

public class SomeEgyptianFractionsTests
{
    [Theory]
    [InlineData("3", "4", "[1/2, 1/4]")]
    [InlineData("12", "4", "[3]")]
    [InlineData("0", "2", "[]")]
    [InlineData("9", "10", "[1/2, 1/3, 1/15]")]
    [InlineData("21", "23", "[1/2, 1/3, 1/13, 1/359, 1/644046]")]
    [InlineData("1", "1", "[1]")]
    [InlineData("4", "5", "[1/2, 1/4, 1/20]")]
    [InlineData("5", "121", "[1/25, 1/757, 1/763309, 1/873960180913, 1/1527612795642093418846225]")]
    public void Decompose_ValidFractions_ReturnsCorrectDecomposition(string numerator, string denominator,
        string expected)
    {
        // Act
        var result = SomeEgyptianFractions.Decompose(numerator, denominator);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Decompose_ZeroNumerator_ReturnsEmptyList()
    {
        // Arrange
        const string numerator = "0";
        const string denominator = "5";

        // Act
        var result = SomeEgyptianFractions.Decompose(numerator, denominator);

        // Assert
        result.Should().Be("[]");
    }

    [Fact]
    public void Decompose_LargeNumbers_DoesNotThrowException()
    {
        // Arrange
        const string numerator = "1234567890123456789012345678901234567890";
        const string denominator = "9876543210987654321098765432109876543210";

        // Act
        Action act = () => SomeEgyptianFractions.Decompose(numerator, denominator);

        // Assert
        act.Should().NotThrow();
    }

    [Theory]
    [InlineData("abc", "5")]
    [InlineData("5", "abc")]
    [InlineData("", "5")]
    [InlineData("5", "")]
    public void Decompose_InvalidInput_ThrowsFormatException(string numerator, string denominator)
    {
        // Act
        Action act = () => SomeEgyptianFractions.Decompose(numerator, denominator);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [Fact]
    public void Decompose_ZeroDenominator_ThrowsDivideByZeroException()
    {
        // Arrange
        const string numerator = "5";
        const string denominator = "0";

        // Act
        Action act = () => SomeEgyptianFractions.Decompose(numerator, denominator);

        // Assert
        act.Should().Throw<DivideByZeroException>();
    }
}