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
            DateTime firstStart = DateTime.Now;
            DateTime firstEnd = firstStart.AddDays(20);
            DateTime secondStart = firstStart.AddDays(15);
            DateTime secondEnd = firstStart.AddDays(30);
            bool result = OtherAlgorithms.IsIncluded(firstStart,firstEnd,secondStart,secondEnd);
            Console.WriteLine(result);
            Console.WriteLine("тест коммитт");
            Console.ReadKey();
        }
    }
}
