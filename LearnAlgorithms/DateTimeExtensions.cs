using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    public static class DateTimeExtensions
    {
        public static DateTime AddWeeks(this DateTime date, int value)
        {
            DateTime newDate = date.AddDays(value*7);
            return newDate;
        }

        public static DateTime StartWeek(this DateTime date, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            int dayValue = (7 + (date.DayOfWeek - startOfWeek)) % 7;
            DateTime startWeek = date.AddDays(-1 * dayValue);
            return startWeek;
        }

        public static DateTime EndWeek(this DateTime date, DayOfWeek endOfWeek = DayOfWeek.Sunday)
        {
            int dayValue = (7 + (date.DayOfWeek - endOfWeek)) % 7;
            DateTime endWeek = date.AddDays(7 - dayValue);
            return endWeek;
        }
    }
}
