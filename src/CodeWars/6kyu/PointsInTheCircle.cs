namespace CodeWars._6kyu;

public static class PointsInTheCircle
{
    public static int PointsNumber(int radius)
    {
        var count = 0;
        for (var x = -radius; x <= radius; x++)
        {
            for (var y = -radius; y <= radius; y++)
            {
                if (x * x + y * y <= radius * radius)
                {
                    count++;
                }
            }
        }
        return count;
    }
}