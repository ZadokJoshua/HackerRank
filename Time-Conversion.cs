    public static string timeConversion(string s)
    {
        DateTime dateTime = Convert.ToDateTime(s);
        return dateTime.ToString("HH:mm:ss");
        // "HH"  The hour, using a 24-hour clock from 00 to 23.
    }
