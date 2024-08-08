using System.Diagnostics;
using CodeWars._5kyu;
using FluentAssertions;

namespace CodeWars.Tests._5kyu;

public class AffordableVacationTests
{
    [Theory]
    [InlineData(10, 3, new int[] { 2, 3, 4 }, "money: 9", "Full duration affordable")]
    [InlineData(10, 3, new int[] { 3, 3, 4 }, "money: 10", "Exactly affordable")]
    [InlineData(10, 3, new int[] { 5, 1, 2, 3 }, "money: 6", "Cheapest period not at start")]
    [InlineData(10, 1, new int[] { 5, 3, 7, 2, 8 }, "money: 2", "Single day requested")]
    [InlineData(10, 5, new int[] { 0, 0, 0, 0, 0 }, "money: 0", "All costs zero")]
    public void FindMinCost_AffordableScenarios_ShouldReturnCorrectMinCost(int money, int days, int[] cost, string expected, string scenario)
    {
        // Arrange & Act
        var result = AffordableVacation.FindMinCost(money, days, cost);

        // Assert
        result.Should().Be(expected, because: scenario);
    }

    [Theory]
    [InlineData(10, 3, new int[] { 3, 6, 7, 4 }, "days: 2", "Full duration not affordable")]
    [InlineData(5, 3, new int[] { 3, 3, 3, 3 }, "days: 1", "All periods unaffordable")]
    public void FindMinCost_UnaffordableScenarios_ShouldReturnMaxDays(int money, int days, int[] cost, string expected, string scenario)
    {
        // Arrange & Act
        var result = AffordableVacation.FindMinCost(money, days, cost);

        // Assert
        result.Should().Be(expected, because: scenario);
    }

    [Fact]
    public void FindMinCost_InsufficientDays_ShouldReturnZeroDays()
    {
        // Arrange
        const int money = 10;
        const int days = 3;
        int[] cost = [2];

        // Act
        var result = AffordableVacation.FindMinCost(money, days, cost);

        // Assert
        result.Should().Be("days: 0");
    }

    [Fact]
    public void FindMinCost_LargeInput_ShouldCompleteQuickly()
    {
        // Arrange
        const int money = 1000000;
        const int days = 10000;
        var cost = new int[100000];
        for (var i = 0; i < cost.Length; i++)
        {
            cost[i] = i % 100 + 1; // Costs from 1 to 100
        }
        
        // Act
        var stopwatch = Stopwatch.StartNew();
        AffordableVacation.FindMinCost(money, days, cost);
        stopwatch.Stop();

        // Assert
        stopwatch.ElapsedMilliseconds.Should().BeLessThan(1000, because: "the method should complete in less than 1 second");
    }
}