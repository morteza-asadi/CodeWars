using CodeWars._5kyu;
using FluentAssertions;

namespace CodeWars.Tests._5kyu;

public class NotVerySecureTests
{
    [Theory]
    [InlineData("Mazinkaiser", true)]
    [InlineData("hello world_", false)]
    [InlineData("PassW0rd", true)]
    [InlineData("     ", false)]
    [InlineData("Abc123", true)] // Valid alphanumeric string
    [InlineData("", false)] // Empty string
    [InlineData("Abc 123", false)] // String with spaces
    [InlineData("Abc@123", false)] // String with special characters
    [InlineData("Abc_123", false)] // String with underscores
    [InlineData("123456", true)] // Numeric string
    [InlineData("ABCDEFG", true)] // Uppercase string
    [InlineData("abcdefg", true)] // Lowercase string
    [InlineData("AbcD123", true)] // Mixed alphanumeric
    public void Alphanumeric_InputVariations_ExpectedResults(string input, bool expected)
    {
        // Act
        var result = NotVerySecure.Alphanumeric(input);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Alphanumeric_SingleCharacter_ReturnsTrue()
    {
        // Arrange
        const string input = "A";

        // Act
        var result = NotVerySecure.Alphanumeric(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Alphanumeric_SingleDigit_ReturnsTrue()
    {
        // Arrange
        const string input = "5";

        // Act
        var result = NotVerySecure.Alphanumeric(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Alphanumeric_LongAlphanumericString_ReturnsTrue()
    {
        // Arrange
        const string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        // Act
        var result = NotVerySecure.Alphanumeric(input);

        // Assert
        result.Should().BeTrue();
    }
}