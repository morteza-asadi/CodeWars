namespace CodeWars._5kyu;

public static class AffordableVacation
{
    public static string FindMinCost(int money, int days, int[] cost)
    {
        if (cost.Length < days)
            return "days: 0";

        var n = cost.Length;
        long windowSum = 0;
        var minCost = long.MaxValue;
        var maxDays = 0;

        for (var i = 0; i < days; i++)
        {
            windowSum += cost[i];
        }

        if (windowSum <= money)
        {
            minCost = windowSum;
            maxDays = days;
        }

        for (var i = days; i < n; i++)
        {
            windowSum = windowSum - cost[i - days] + cost[i];
            if (windowSum <= money)
            {
                minCost = Math.Min(minCost, windowSum);
                maxDays = days;
            }
        }

        if (maxDays < days)
        {
            int left = 0, right = 0;
            windowSum = 0;

            while (right < n)
            {
                windowSum += cost[right];
                while (windowSum > money && left <= right)
                {
                    windowSum -= cost[left];
                    left++;
                }
                maxDays = Math.Max(maxDays, right - left + 1);
                right++;
            }
        }

        return (maxDays == days) ? $"money: {minCost}" : $"days: {maxDays}";
    }
}