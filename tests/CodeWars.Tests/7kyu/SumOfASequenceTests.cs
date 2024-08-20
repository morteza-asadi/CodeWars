using CodeWars._7kyu;
using FluentAssertions;

namespace CodeWars.Tests._7kyu;

public class SumOfASequenceTests
{
    [Theory]
    [InlineData(2, 2, 2, 2)]
    [InlineData(2, 6, 2, 12)]
    [InlineData(1, 5, 1, 15)]
    [InlineData(1, 5, 3, 5)]
    [InlineData(0, 10, 5, 15)]
    [InlineData(10, 10, 2, 10)]
    [InlineData(10, 1, 1, 0)]
    public void SequenceSum_ValidInputs_ReturnsCorrectSum(int start, int end, int step, int expectedSum)
    {
        // Act
        var result = SumOfASequence.SequenceSum(start, end, step);

        // Assert
        result.Should().Be(expectedSum);
    }

    [Fact]
    public void SequenceSum_startGreaterThanEnd_ReturnsZero()
    {
        // Arrange
        const int start = 10;
        const int end = 5;
        const int step = 2;

        // Act
        var result = SumOfASequence.SequenceSum(start, end, step);

        // Assert
        result.Should().Be(0);
    }
}