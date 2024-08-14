using CodeWars._4kyu;
using FluentAssertions;

namespace CodeWars.Tests._4kyu;

public class DoubleLinearTests
{
    [Theory]
    [InlineData(10, 22)]
    [InlineData(20, 57)]
    [InlineData(30, 91)]
    [InlineData(50, 175)]
    [InlineData(0, 1)]
    public void DblLinear_ValidIndex_ReturnsExpectedElement(int index, int expected)
    {
        // Act
        var result = DoubleLinear.DblLinear(index);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Fact]
    public void DblLinear_ZeroIndex_ReturnsOne()
    {
        // Arrange
        const int index = 0;

        // Act
        var result = DoubleLinear.DblLinear(index);

        // Assert
        result.Should().Be(1);
    }
}