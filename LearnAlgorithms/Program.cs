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
            int[] array = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 , 12, 13, 25};

            int result = FindAlgorithms.BinarySearch(array,11);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
