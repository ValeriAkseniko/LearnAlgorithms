using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(12);
            int result = OtherAlgorithms.CountDayOff(start, end);
            Console.WriteLine(result);
            Console.WriteLine();
            List<DateTime> test = new List<DateTime>();
            test = OtherAlgorithms.ListDayOff(start, end);
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i].ToLongDateString());
            }
            Console.WriteLine();
            DateTime[] test2 = OtherAlgorithms.ArrayDayOff(start, end);
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i].ToLongDateString());
            }
            Console.ReadKey();
        }
    }
}
