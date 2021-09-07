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
            string text = "я просто не совсем понимаю.можно обратиться к строчке в словаре по значению, а не по ключу ? ";

            Dictionary<string, int> result = new Dictionary<string, int>();

            result = StringAlgorithms.GetWordStatistic(text);
        }
    }
}
