namespace CodeWars._4kyu;

public static class DoubleLinear
{
    public static int DblLinear(int index)
    {
        var sequenceSet = new SortedSet<int>();
        var seenElements = new HashSet<int>();

        sequenceSet.Add(1);
        seenElements.Add(1);

        var currentElement = 0;

        for (var i = 0; i <= index; i++)
        {
            currentElement = sequenceSet.Min;
            sequenceSet.Remove(currentElement);

            var nextElement1 = 2 * currentElement + 1;
            var nextElement2 = 3 * currentElement + 1;

            if (seenElements.Add(nextElement1))
            {
                sequenceSet.Add(nextElement1);
            }

            if (seenElements.Add(nextElement2))
            {
                sequenceSet.Add(nextElement2);
            }
        }

        return currentElement;
    }
}