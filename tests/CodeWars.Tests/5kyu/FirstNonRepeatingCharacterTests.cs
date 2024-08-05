using CodeWars._5kyu;
using FluentAssertions;

namespace CodeWars.Tests._5kyu;

public class FirstNonRepeatingCharacterTests
{
    [Theory]
    [InlineData("stress", "t")]
    [InlineData("sTreSS", "T")]
    [InlineData("moonmen", "e")]
    [InlineData("", "")]
    [InlineData("aabbcc", "")]
    [InlineData("a", "a")]
    [InlineData("abcdef", "a")]
    [InlineData("sTreSsW", "T")]
    [InlineData("αβγδεζηαβγδζη", "ε")]
    [InlineData("1122334455@@££", "")]
    [InlineData("a a b c", "b")]
    [InlineData("aAbBcC", "")]
    public void FirstNonRepeatingLetter_NormalInputs_ReturnsFirstNonRepeatingLetter(string input, string expected)
    {
        // Act
        var result = FirstNonRepeatingCharacter.FirstNonRepeatingLetter(input);
        
        // Assert
        result.Should().Be(expected, because: "First non-repeating letter in '{0}' should be '{1}'", input,expected);
    }
    
    [Fact]
    public void FirstNonRepeatingLetter_VeryLongString_ReturnsCorrectCharacter()
    {   
        // Arrange
        var longInput = new string('a', 1000000) + "b" + new string('a', 1000000);
        const string expected = "b";
        
        // Act
        var result = FirstNonRepeatingCharacter.FirstNonRepeatingLetter(longInput);
        
        // Assert
        result.Should().Be(expected, "Very long string should return '{1}'", expected);
    }

    [Fact]
    public void FirstNonRepeatingLetter_NullInput_ReturnsEmptyString()
    {
        // Act
        var result = FirstNonRepeatingCharacter.FirstNonRepeatingLetter(null);
        
        // Assert
        result.Should().BeEmpty("Null input should return empty string");
    }
}