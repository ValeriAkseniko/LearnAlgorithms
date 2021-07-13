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
            double days = (end - start).TotalDays;
            List<DateTime> allDays = new List<DateTime>();
            int j = 0;
            for (DateTime i = start; j <= days; j++)
            {
                allDays.Add(i);
                i = i.AddDays(1);
            }
            for (int i = 0; i < allDays.Count; i++)
            {
                if (allDays[i].DayOfWeek == DayOfWeek.Sunday || allDays[i].DayOfWeek == DayOfWeek.Saturday)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
