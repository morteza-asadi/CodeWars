using CodeWars._4kyu;
using FluentAssertions;

namespace CodeWars.Tests._4kyu;

public class NextBiggerNumberWithTheSameDigitsTests
{
    [Theory]
    [InlineData(12, 21)]
    [InlineData(513, 531)]
    [InlineData(2017, 2071)]
    public void NextBiggerNumber_ValidNumber_ReturnsNextPermutation(long input, long expected)
    {
        // act
        var result = NextBiggerNumberWithTheSameDigits.NextBiggerNumber(input);

        // assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(9, -1)]
    [InlineData(111, -1)]
    [InlineData(531, -1)]
    public void NextBiggerNumber_NoPossiblePermutation_ReturnsNegativeOne(long input, long expected)
    {
        // act
        var result = NextBiggerNumberWithTheSameDigits.NextBiggerNumber(input);

        // assert
        result.Should().Be(expected);
    }

    [Fact]
    public void NextBiggerNumber_LargeNumber_CorrectlyRearrangedNumber()
    {
        // arrange
        const long input = 59884848459853;
        const long expected = 59884848483559;

        // act
        var result = NextBiggerNumberWithTheSameDigits.NextBiggerNumber(input);

        // assert
        result.Should().Be(expected);
    }
}