public static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int ValidPairs = 0;
    int CurrentNumber = 0;

    for (int j = 0; j < n; j++)
    {
        CurrentNumber = ar[j];
        if(j == (n-1))
        {
            break;
        }
        else
        {
            for(int i = j + 1; i < n; i ++)
            {
                if((CurrentNumber + ar[i]) % k == 0)
                {
                    ValidPairs++;
                }
            }
        }

    }

    return ValidPairs;
}
