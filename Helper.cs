public static class Helper
{
    public static List<int> GetRandomNumbers()
    {
        List<int> numbers = Enumerable.Range(1, 100).ToList();
        Random rand = new Random();
        for (int i = numbers.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            int temp = numbers[j];
            numbers[j] = numbers[i];
            numbers[i] = temp;
        }
        return numbers;
    }
}