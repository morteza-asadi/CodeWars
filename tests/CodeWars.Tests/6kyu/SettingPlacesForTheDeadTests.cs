using CodeWars._6kyu;
using FluentAssertions;

namespace CodeWars.Tests._6kyu;

public class SettingPlacesForTheDeadTests
{
     [Fact]
    public void SetTable_SingleGhost_SeatsCorrectly()
    {
        // Arrange
        string[] theDead = ["Artlu"];
        string[] expected = ["_____", "_____", "_____", "_____", "_____", "_____", "Artlu", "_____", "_____", "_____", "_____", "_____"
        ];

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SetTable_FourGhosts_SeatsCorrectly()
    {
        // Arrange
        string[] theDead = ["Artlu", "Breca", "Cityl", "Dedaf"];
        string[] expected = ["Cityl", "_____", "_____", "_____", "_____", "Breca", "Artlu", "_____", "_____", "_____", "_____", "Dedaf"
        ];

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SetTable_AllFavorSameFeature_SeatsCorrectly()
    {
        // Arrange
        string[] theDead = ["Sevap", "Syolc", "Sgulg", "Stolb", "Sknoh", "Spord", "Sgnaf", "Shcat", "Sknit", "Snirg", "Senin", "Sliob"
        ];
        string[] expected = ["Sgnaf", "Sknit", "Senin", "Sliob", "Snirg", "Shcat", "Spord", "Stolb", "Syolc", "Sevap", "Sgulg", "Sknoh"
        ];

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SetTable_ExampleFromDescription_SeatsCorrectly()
    {
        // Arrange
        string[] theDead = ["Yojne", "Xenna", "Verap", "Ebyam", "Teseb", "Ycuag", "Onets", "Skcaw", "Yrovi", "Tpets", "Lizuf", "Girnu"
        ];
        string[] expected = ["Teseb", "Onets", "Verap", "Xenna", "Ebyam", "Ycuag", "Yojne", "Yrovi", "Lizuf", "Skcaw", "Girnu", "Tpets"
        ];

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SetTable_TooManyGhosts_SeatsFirstTwelveCorrectly()
    {
        // Arrange
        string[] theDead = ["Egdob", "Liame", "Skceg", "Yesba", "Cinid", "Sallo", "Sumac", "Triks", "Sipat", "Elona", "Sreod", "Deyab", "Dlaps", "Nevey", "Htron"
        ];
        string[] expected = ["Cinid", "Sreod", "Elona", "Egdob", "Deyab", "Yesba", "Liame", "Sipat", "Sallo", "Skceg", "Sumac", "Triks"
        ];

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Theory]
    [InlineData(new object[] { new string[0] })]
    [InlineData(new object[] { new[] { "Ghost" } })]
    [InlineData(new object[] { new[] { "Ghost1", "Ghost2", "Ghost3", "Ghost4", "Ghost5" } })]
    public void SetTable_VariousInputSizes_AlwaysReturnsTwelveSeats(string[] theDead)
    {
        // Arrange
        const int expectedSeats = 12;

        // Act
        var result = SettingPlacesForTheDead.SetTable(theDead);

        // Assert
        result.Should().HaveCount(expectedSeats);
    }
}