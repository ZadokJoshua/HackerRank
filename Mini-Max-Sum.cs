public static void miniMaxSum(List<int> arr)
{
    // Converted the list<int> to list<long> using ConvertAll
    List<long> longs = arr.ConvertAll(i => (long)i);
    long arrLength = longs.Count;
    long originalSum = longs.Sum();
    List<long> sumsStorage = new List<long>();

    for(int i = 0; i < arrLength; i ++)
    {
        long tempSum = originalSum;
        tempSum -= longs[i];
        sumsStorage.Add(tempSum);
    }

    long min = sumsStorage.Min();
    long max = sumsStorage.Max();
    Console.WriteLine(min + " " + max);
}
