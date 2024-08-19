using CodeWars._6kyu;
using FluentAssertions;

namespace CodeWars.Tests._6kyu;

public class PointsInTheCircleTests
{
    [Fact]
    public void PointsNumber_RadiusZero_ReturnsOne()
    {
        // Arrange
        const int radius = 0;
        
        // Act
        var result = PointsInTheCircle.PointsNumber(radius);
        
        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void PointsNumber_RadiusTwo_ReturnsThirteen()
    {
        // Arrange
        const int radius = 2;
        
        // Act
        var result = PointsInTheCircle.PointsNumber(radius);
        
        // Assert
        result.Should().Be(13);
    }

    [Theory]
    [InlineData(1, 5)]
    [InlineData(3, 29)]
    [InlineData(5, 81)]
    [InlineData(10, 317)]
    public void PointsNumber_GivenRadius_ReturnsExpectedCount(int radius, int expectedCount)
    {
        // Act
        var result = PointsInTheCircle.PointsNumber(radius);
        
        // Assert
        result.Should().Be(expectedCount);
    }
}