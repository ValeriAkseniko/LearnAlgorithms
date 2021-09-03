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
            string text = "Соответствующее соглашение было подписано на ВЭФ. Под комплексную застройку города выделят 925 га территории опережающего социально-экономического развития «Надеждинская» - она расположена в 40 км от Владивостока и в 15 км от Артема.";

            Dictionary<string, int> result = new Dictionary<string, int>();

            result = StringAlgorithms.GetWordStatistic(text);
        }
    }
}
