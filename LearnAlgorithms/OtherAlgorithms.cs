using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class OtherAlgorithms
    {
        public static int CountDayOff(DateTime start, DateTime end)
        {
            int result = 0;
            for (DateTime currentDate = start; currentDate.Date <= end.Date; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    result++;
                }
            }
            return result;
        }

        public static List<DateTime> ListDayOff(DateTime start, DateTime end)
        {
            List<DateTime> result = new List<DateTime>();
            for (DateTime currentDate = start; currentDate.Date <= end.Date; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    result.Add(currentDate);
                }
            }
            return result;
        }

        public static DateTime[] ArrayDayOff(DateTime start, DateTime end)
        {
            int arrayLength = CountDayOff(start, end);
            DateTime[] result = new DateTime[arrayLength];
            int i = 0;
            for (DateTime currentDate = start; currentDate.Date <= end.Date; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    result[i] = currentDate;
                    i++;
                }
            }
            return result;
        }

        public static List<DateTime> listDates(DateTime start, DateTime end)
        {
            List<DateTime> result = new List<DateTime>();
            for (DateTime currentDate = start; currentDate.Date <= end.Date; currentDate = currentDate.AddDays(1))
            {
                result.Add(currentDate);
            }
            return result;
        }

        public static bool IsIncluded(DateTime star, DateTime end, DateTime date)
        {
            List<DateTime> dates = listDates(star, end);
            for (int i = 0; i < dates.Count; i++)
            {
                if (dates[i].Date == date.Date)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsIncluded(DateTime startFirst,DateTime endFirst,DateTime startSecond,DateTime endSecond)
        {
            List<DateTime> firstDates = listDates(startFirst, endFirst);
            List<DateTime> secondDates = listDates(startSecond, endSecond);
            for (int i = 0; i < firstDates.Count; i++)
            {
                if (secondDates.Contains(firstDates[i]))
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
