using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    public static class DateTimeExtendings
    {
        public static DateTime AddWeeks(this DateTime date, int value)
        {
            DateTime newDate = date.AddDays(value*7);
            return newDate;
        }

        public static DateTime StartWeek(this DateTime date)
        {
            int dayValue = (int)date.DayOfWeek;
            DateTime startWeek = date.AddDays(-1 * dayValue);
            return startWeek;
        }

        public static DateTime EndWeek(this DateTime date)
        {
            int dayValue = (int)date.DayOfWeek;
            DateTime endWeek = date.AddDays(7 - dayValue);
            return endWeek;
        }
    }
}
