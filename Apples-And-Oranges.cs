    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int applesAtInclusiveRange = 0;
        int orangesAtInclusiveRange = 0;
        
        for(int i = 0; i < apples.Count; i++)
        {
            apples[i] += a;
            if(apples[i] >= s && apples[i] <= t)
            {
                applesAtInclusiveRange += 1;
            }
        }
        
        for(int i = 0; i < oranges.Count; i++)
        {
            oranges[i] += b;
            if(oranges[i] >= s && oranges[i] <= t)
            {
                orangesAtInclusiveRange += 1;
            }
        }
        
        Console.WriteLine(applesAtInclusiveRange);
        Console.WriteLine(orangesAtInclusiveRange);
    }
