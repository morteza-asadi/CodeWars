using CodeWars._5kyu;
using FluentAssertions;

namespace CodeWars.Tests._5kyu;

public class CountIpAddressesTests
{
    [Theory]
    [InlineData("10.0.0.0", "10.0.0.50", 50)]
    [InlineData("10.0.0.0", "10.0.1.0", 256)]
    [InlineData("20.0.0.10", "20.0.1.0", 246)]
    [InlineData("10.11.12.13", "10.11.12.14", 1)]
    [InlineData("160.0.0.0", "160.0.1.0", 256)]
    [InlineData("170.0.0.0", "170.1.0.0", 65536)]
    [InlineData("50.0.0.0", "50.1.1.1", 65793)]
    [InlineData("180.0.0.0", "181.0.0.0", 16777216)]
    public void IpsBetween_ShouldReturnCorrectCount(string start, string end, long expected)
    {
        CountIpAddresses.IpsBetween(start, end).Should().Be(expected);
    }
}