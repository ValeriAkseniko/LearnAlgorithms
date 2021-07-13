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
            string testText = "Teet";
            bool result = StringAlgorithms.IsPalindrom(testText);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
