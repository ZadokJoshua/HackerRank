public static void miniMaxSum(List<int> arr)
{
    int arrLength = arr.Count;
    int originalSum = arr.Sum();
    List<int> sumsStorage = new List<int>();

    for(int i = 0; i < arrLength; i ++)
    {
        int tempSum = originalSum;
        tempSum -= arr[i];
        sumsStorage.Add(tempSum);
    }

    int min = sumsStorage.Min();
    int max = sumsStorage.Max();
    Console.WriteLine(min + " " + max);
}
