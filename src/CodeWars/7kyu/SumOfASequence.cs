namespace CodeWars._7kyu;

public static class SumOfASequence
{
    public static int SequenceSum(int start, int end, int step)
    {
        if (start > end) return 0;
        var sum = 0;
        for (var i = start; i <= end; i += step)
            sum += i;
        return sum;
    }
}