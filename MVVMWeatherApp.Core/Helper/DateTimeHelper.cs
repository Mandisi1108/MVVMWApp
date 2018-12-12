using System;

namespace MVVMWeatherApp.Core.Helper
{
    public class DateTimeHelper
    {
        public string GetDate(int unixTimeStamp, DateTimeFormat format, bool localTime = false)
        {
            var DateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DateTime = DateTime.AddSeconds(unixTimeStamp);
            if (localTime)
            {
                DateTime = DateTime.ToLocalTime();
            }
            switch (format)
            {
                case DateTimeFormat.Date:
                    return DateTime.ToString("M");
                case DateTimeFormat.Time:
                    return DateTime.ToString("t");
                case DateTimeFormat.FullDate:
                    return DateTime.ToString("f");
                default:
                    return DateTime.ToString();
            }
        }
        public enum DateTimeFormat
        {
            Default, FullDate, Date, Time
        }
    }
}
