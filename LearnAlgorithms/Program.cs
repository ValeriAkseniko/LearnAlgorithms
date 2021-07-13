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
            Console.ReadKey();
        }
    }
}
