using CodeWars._6kyu;
using FluentAssertions;

namespace CodeWars.Tests._6kyu;

public class GoodVsEvilBattleTests
{
    [Theory]
    [InlineData("1 0 0 0 0 0", "0 0 0 0 0 0 0", "Battle Result: Good triumphs over Evil")]
    [InlineData("0 0 0 0 0 0", "1 0 0 0 0 0 0", "Battle Result: Evil eradicates all trace of Good")]
    [InlineData("0 0 0 0 0 0", "0 0 0 0 0 0 0", "Battle Result: No victor on this battle field")]
    [InlineData("1 1 1 1 1 1", "1 1 1 1 1 1 1", "Battle Result: Evil eradicates all trace of Good")]
    public void GoodVsEvil_DifferentScenarios_ExpectedResults(string good, string evil, string expectedResult)
    {
        // Arrange - Done via InlineData

        // Act
        var result = GoodVsEvilBattle.GoodVsEvil(good, evil);

        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void GoodVsEvil_GoodStronger_ExpectedGoodWins()
    {
        // Arrange
        const string good = "2 3 1 1 1 1"; // Total worth = 26
        const string evil = "1 1 1 1 1 1 1"; // Total worth = 25

        // Act
        var result = GoodVsEvilBattle.GoodVsEvil(good, evil);

        // Assert
        result.Should().Be("Battle Result: Good triumphs over Evil");
    }

    [Fact]
    public void GoodVsEvil_EvilStronger_ExpectedEvilWins()
    {
        // Arrange
        const string good = "0 0 0 0 0 0";  // Total worth = 0
        const string evil = "1 1 1 1 1 1 1"; // Total worth = 25

        // Act
        var result = GoodVsEvilBattle.GoodVsEvil(good, evil);

        // Assert
        result.Should().Be("Battle Result: Evil eradicates all trace of Good");
    }
}