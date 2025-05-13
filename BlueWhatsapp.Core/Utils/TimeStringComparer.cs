using System.Globalization;

namespace BlueWhatsapp.Core.Utils;

public sealed class TimeStringComparer : IComparer<string>
{
    public int Compare(string timeStr1, string timeStr2)
    {
        if (string.IsNullOrEmpty(timeStr1) && string.IsNullOrEmpty(timeStr2))
            return 0;
        if (string.IsNullOrEmpty(timeStr1))
            return -1;
        if (string.IsNullOrEmpty(timeStr2))
            return 1;

        // Parse the time strings to TimeSpan objects for comparison
        if (TryParseTimeString(timeStr1, out TimeSpan time1) &&
            TryParseTimeString(timeStr2, out TimeSpan time2))
        {
            return time1.CompareTo(time2);
        }

        // Fall back to string comparison if parsing fails
        return string.Compare(timeStr1, timeStr2, StringComparison.Ordinal);
    }

    private bool TryParseTimeString(string timeStr, out TimeSpan timeSpan)
    {
        timeSpan = TimeSpan.Zero;

        // Handle both formats observed in your data: "9:00 AM" and "2:10 PM" (no leading zero)
        string[] formats = { "h:mm tt", "hh:mm tt" };

        if (DateTime.TryParseExact(
                timeStr,
                formats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedTime))
        {
            timeSpan = parsedTime.TimeOfDay;
            return true;
        }

        return false;
    }
}