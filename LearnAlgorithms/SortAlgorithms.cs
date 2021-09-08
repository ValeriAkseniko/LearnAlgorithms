using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class SortAlgorithms
    {
        public static void Mix(int[] array, int countSwap = 100)
        {
            Random rnd = new Random();
            int maxIndex = array.Length - 1;
            for (int i = 0; i < countSwap; i++)
            {
                int firstIndex = rnd.Next(0, maxIndex);
                int secondIndex = rnd.Next(0, maxIndex);
                int blank = array[firstIndex];
                array[firstIndex] = array[secondIndex];
                array[secondIndex] = blank;
            }
        }
        public static void Mix(List<int> list, int countSwap = 100)
        {
            Random rnd = new Random();
            int maxIndex = list.Count;
            for (int i = 0; i < countSwap; i++)
            {
                int firstIndex = rnd.Next(0, maxIndex);
                int secondIndex = rnd.Next(0, maxIndex);
                int blank = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = blank;
            }
        }

        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }

        public static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
