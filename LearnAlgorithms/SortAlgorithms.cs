using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class SortAlgorithms
    {
        public static void Mix(int[] array)
        {
            Random rnd = new Random();
            int maxIndex = array.Length - 1;
            for (int i = 0; i < rnd.Next(0, 100); i++)
            {
                int firstIndex = rnd.Next(0, maxIndex);
                int secondIndex = rnd.Next(0, maxIndex);
                int blank = array[firstIndex];
                array[firstIndex] = array[secondIndex];
                array[secondIndex] = blank;
            }
        }
        public static void Mix(List<int> list)
        {
            Random rnd = new Random();
            int maxIndex = list.Count;
            for (int i = 0; i < rnd.Next(0,100); i++)
            {
                int firstIndex = rnd.Next(0, maxIndex);
                int secondIndex = rnd.Next(0, maxIndex);
                int blank = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = blank;
            }
        }
    }
}
