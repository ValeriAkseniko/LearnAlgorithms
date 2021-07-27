using LearnAlgorithms.Enums;
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
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        public static void PrintForEach(List<int> numbers)
        {
            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void PrintWhile(List<int> numbers)
        {
            if (numbers != null)
            {
                int i = 0;
                while (i < numbers.Count)
                {
                    Console.WriteLine(numbers[i]);
                    i++;
                }
            }
        }

        public static void PrintDoWhile(List<int> numbers)
        {
            if (numbers != null || numbers.Count > 0)
            {
                int i = 0;
                do
                {
                    Console.WriteLine(numbers[i]);
                    i++;
                } while (i < numbers.Count);
            }
        }

        public static void Print(List<int> numbers, CycleType cycleType)
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
                case CycleType.ForEach:
                    PrintForEach(numbers);
                    break;
            }
        }

        public static string CaesarEncryption(string text, int key)
        {
            char[] array = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int code = (int)text[i];
                code += key;
                array[i] = (char)code;
            }
            string newText = new string(array);
            return newText;
        }

        public static string CaesarDecryption(string text, int key)
        {
            char[] array = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int code = (int)text[i];
                code -= key;
                array[i] = (char)code;
            }
            string newText = new string(array);
            return newText;
        }

        public static DateTime GetStartMonth(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            DateTime startMonth = new DateTime(year, month, 1);
            return startMonth;
        }

        public static DateTime GetEndMonth(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int days = DateTime.DaysInMonth(year, month);
            DateTime endMonth = new DateTime(year, month, days);
            return endMonth;
        }

        public static Month GetMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    return Month.January;
                    break;
                case 2:
                    return Month.February;
                    break;
                case 3:
                    return Month.March;
                    break;
                case 4:
                    return Month.April;
                    break;
                case 5:
                    return Month.May;
                    break;
                case 6:
                    return Month.June;
                    break;
                case 7:
                    return Month.July;
                    break;
                case 8:
                    return Month.August;
                    break;
                case 9:
                    return Month.September;
                    break;
                case 10:
                    return Month.October;
                    break;
                case 11:
                    return Month.November;
                    break;
                case 12:
                    return Month.December;
                    break;
                default:
                    return Month.Nan;
                    break;
            }
        }

        public static Month GetMonth(int number)
        {
            if (number <= 12)
            {
                switch (number)
                {
                    case 1:
                        return Month.January;
                        break;
                    case 2:
                        return Month.February;
                        break;
                    case 3:
                        return Month.March;
                        break;
                    case 4:
                        return Month.April;
                        break;
                    case 5:
                        return Month.May;
                        break;
                    case 6:
                        return Month.June;
                        break;
                    case 7:
                        return Month.July;
                        break;
                    case 8:
                        return Month.August;
                        break;
                    case 9:
                        return Month.September;
                        break;
                    case 10:
                        return Month.October;
                        break;
                    case 11:
                        return Month.November;
                        break;
                    case 12:
                        return Month.December;
                        break;
                    default:
                        return Month.Nan;
                        break;
                }
            }
            return Month.Nan;
        }

    }
}
