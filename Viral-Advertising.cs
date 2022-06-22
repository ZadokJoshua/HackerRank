public static int viralAdvertising(int n)
{
    int sharedTo = 5;
    int cummulativeLikes = 0;

    for(int dayProgression = 1; dayProgression < (n + 1); dayProgression++)
    {
        int liked = sharedTo / 2;
        sharedTo = liked * 3;
        cummulativeLikes += liked;
    }

    return cummulativeLikes;
}
