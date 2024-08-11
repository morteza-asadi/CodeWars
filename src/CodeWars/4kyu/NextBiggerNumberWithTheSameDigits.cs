namespace CodeWars._4kyu;

public static class NextBiggerNumberWithTheSameDigits
{
    public static long NextBiggerNumber(long n)
    {
        var numbers = n.ToString().ToCharArray();
        var i = numbers.Length - 2;

        // Find non-increasing suffix
        while (i >= 0 && numbers[i] >= numbers[i + 1]) {
            i--;
        }
        if (i < 0) return -1;
        
        // Find successor to pivot
        var j = numbers.Length - 1;
        while (numbers[j] <= numbers[i]) {
            j--;
        }

        // Swap using tuple assignment
        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);

        // Reverse suffix
        Reverse(numbers, i + 1, numbers.Length - 1);

        return long.Parse(new string(numbers));
    }

    private static void Reverse(char[] array, int start, int end) {
        while (start < end) {
            (array[start], array[end]) = (array[end], array[start]);
            start++;
            end--;
        }
    }
}