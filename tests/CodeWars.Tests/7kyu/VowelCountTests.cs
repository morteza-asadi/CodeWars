using CodeWars._7kyu;
using FluentAssertions;

namespace CodeWars.Tests._7kyu;

public class VowelCountTests
{
    [Theory]
    [InlineData("example",3)]
    [InlineData("hello", 2)]
    [InlineData("syzygy", 0)]
    [InlineData("aeiou", 5)]
    [InlineData("quick brown fox", 4)]
    public void GetVowelCount_InputWithVariousVowelCounts_ReturnCount(string input, int expected)
    {
        // Act
        var result = VowelCount.GetVowelCount(input);
        // Assert
        result.Should().Be(expected, because: "the number of vowels in '{0}' should be {1}", input, expected);
    }

    [Fact]
    public void GetVowelCount_NoVowels_ReturnZero()
    {
        // Arrange
        const string input = "bcdfghjklmnpqrstvwxyz";
        // Act
        var result = VowelCount.GetVowelCount(input);
        // Assert
        result.Should().Be(0, because: "there are no vowels in the string");
    }

    [Fact]
    public void GetVowelCount_AllVowels_ReturnsStringLength()
    {
        // Arrange
        const string input = "aeiou";
        var expected = input.Length;
        // Act
        var result = VowelCount.GetVowelCount(input);
        // Assert
        result.Should().Be(expected, because: "all characters are vowels");
    }
    
    [Fact]
    public void GetVowelCount_EmptyString_ReturnsZero()
    {
        // Arrange
        var input = string.Empty;
        // Act
        var result = VowelCount.GetVowelCount(input);
        // Assert
        result.Should().Be(0, because: "the string is empty");
    }

    [Fact]
    public void GetVowelCount_OnlySpaces_ReturnsZero()
    {
        // Arrange
        const string input = "     ";
        // Act
        var result = VowelCount.GetVowelCount(input);
        // Assert
        result.Should().Be(0, because: "spaces do not contain any vowels");
    }
}