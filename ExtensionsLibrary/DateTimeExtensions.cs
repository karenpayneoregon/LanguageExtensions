using System;
using System.Globalization;
using System.Text;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Contains extension methods for DateTime and TimeSpan.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert TimeSpan into DateTime
        /// </summary>
        /// <param name="sender">Valid TimeSpan</param>
        /// <returns>DateTime</returns>
        /// <remarks>
        /// Intended to be used when the date part does not matter
        /// </remarks>
        public static DateTime ToDateTime(this TimeSpan sender)
        {
            return DateTime.ParseExact(sender.Formatted("hh:mm"), "H:mm", null, DateTimeStyles.None);
        }
        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns>Formatted TimeSpan as a string</returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt")
        {
            return DateTime.Today.Add(sender).ToString(format);
        }
        /// <summary>
        /// Combine date and time
        /// </summary>
        /// <param name="day">Valid Initialized DateTime</param>
        /// <param name="time">Valid initialized TimeSpan</param>
        /// <returns>Day with Time</returns>
        public static DateTime At(this DateTime day, TimeSpan time)
        {
            return new DateTime(day.Year, day.Month, day.Day, 0, 0, 0).Add(time);
        }
    }
}
