namespace CodeWars._6kyu;

public static class SettingPlacesForTheDead
{
    private static readonly Dictionary<char, int> FeaturePreferences = new()
    {
        { 'Q', 0 }, { 'U', 0 }, { 'T', 0 }, { 'H', 0 }, { 'C', 0 }, { 'R', 0 }, { 'D', 0 }, { 'M', 0 },
        { 'Z', 0 }, // Earthenware
        { 'W', 1 }, { 'E', 1 }, { 'V', 1 }, { 'O', 1 }, { 'X', 1 }, { 'I', 1 }, { 'N', 1 }, { 'G', 1 }, // Waterfall
        { 'J', 2 }, { 'F', 2 }, { 'A', 2 }, { 'B', 2 }, { 'K', 2 }, { 'P', 2 }, { 'L', 2 }, { 'Y', 2 }, // Fireplace
        { 'S', 3 } // Windowsill
    };

    private static readonly int[][] SeatPreferences =
    [
        [1, 12, 2, 11, 3, 10, 4, 9, 5, 8, 6, 7], // Earthenware
        [4, 3, 5, 2, 6, 1, 7, 12, 8, 11, 9, 10], // Waterfall
        [7, 6, 8, 5, 9, 4, 10, 3, 11, 2, 12, 1], // Fireplace
        [10, 9, 11, 8, 12, 7, 1, 6, 2, 5, 3, 4] // Windowsill
    ];

    public static string[] SetTable(string[] theDead)
    {
        var seating = Enumerable.Repeat("_____", 12).ToArray();
        var seatsTaken = new HashSet<int>();

        foreach (var ghost in theDead.Take(12))
        {
            var preferredFeature =
                FeaturePreferences.TryGetValue(char.ToUpper(ghost[0]), out var feature) ? feature : 0;
            var bestSeat = FindBestSeat(preferredFeature, seatsTaken);

            seating[bestSeat - 1] = ghost;
            seatsTaken.Add(bestSeat);
        }

        return seating;
    }

    private static int FindBestSeat(int preferredFeature, HashSet<int> seatsTaken)
        => SeatPreferences[preferredFeature].First(seat => !seatsTaken.Contains(seat));
}