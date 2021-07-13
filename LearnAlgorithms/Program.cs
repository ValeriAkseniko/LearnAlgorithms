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
            string testText = "Норы";
            string testText2 = "НорыНоры";
            bool result = StringAlgorithms.IsAnagram(testText, testText2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
