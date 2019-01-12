using System;

namespace SalesManagement.ENTITY.Utility
{
    public class UnixTime
    {
        public static DateTime UNIX_START = new DateTime(1970, 1, 1);

        public static DateTime GetTimeUnix(int timeUnix)
        {
            return UNIX_START.AddSeconds(timeUnix);
        }

        public static int GetUnixTime(DateTime dateTime)
        {
            if (dateTime.Year < UNIX_START.Year)
                return 0;
            return Convert.ToInt32((dateTime - UNIX_START).TotalSeconds);
        }
    }
}
