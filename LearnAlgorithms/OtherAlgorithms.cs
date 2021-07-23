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

        public static bool IsIncluded(DateTime start, DateTime end, DateTime date)
        {
            if (date.Date <= end && date.Date >= start.Date)
            {
                return true;
            }
            return false;
        }

        public static bool IsIncluded(DateTime startFirst, DateTime endFirst, DateTime startSecond, DateTime endSecond)
        {
            if (!(endFirst < startSecond || startFirst > endSecond))
            {
                return true;
            }
            return false;
        }

        public static void PrintFor(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void PrintForEach(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void PrintWhile(List<int> numbers)
        {
            int i = 0;
            while (i < numbers.Count)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }

        public static void PrintDoWhile(List<int> numbers)
        {
            int i = 0;
            do
            {
                Console.WriteLine(numbers[i]);
                i++;
            } while (i < numbers.Count);
        }
        public static void Print (List<int> numbers,CycleType cycleType)
        {
            switch (cycleType)
            {
                case CycleType.For:
                    PrintFor(numbers);
                    break;
                case CycleType.While:
                    PrintWhile(numbers);
                    break;
                case CycleType.DoWhile:
                    PrintDoWhile(numbers);
                    break;
                case CycleType.Forech:
                    PrintForEach(numbers);
                    break;
            }
        }

    }
}
