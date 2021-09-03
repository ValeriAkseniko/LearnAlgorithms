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

            DateTime test = new DateTime(2021, 9, 7);
            test = test.EndWeek();
        }
    }
}
