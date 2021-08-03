using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class FindAlgorithms
    {
        public static int BinarySearch(int[] array, int value)
        {
            if (value < array[0] || value > array[array.Length-1])
            {
                return -1;                
            }
            int firstIndex = 0;
            int secondIndex = array.Length;
            int result = array.Length / 2;
            int midle = array[result];
            if (midle == value)
            {
                return result;
            }
            else
            {
                if (midle < value)
                {
                    firstIndex = result;
                    return BinarySearch(array, value, firstIndex, secondIndex);
                }
                else if (midle > value)
                {
                    secondIndex = result;
                    return BinarySearch(array, value, firstIndex, secondIndex);
                }
                return -1;
            }

        }
        public static int BinarySearch(int[] array,int value,int firstIndex, int secondIndex)
        {
            if (firstIndex >= secondIndex)
            {
                return -1;
            }
            int result = (firstIndex + secondIndex) / 2;
            int midle = array[result];
            if (midle == value)
            {
                return result;
            }
            else
            {
                if (midle < value)
                {
                    firstIndex = result;
                    return BinarySearch(array, value, firstIndex, secondIndex);
                }
                else if (midle > value)
                {
                    secondIndex = result;
                    return BinarySearch(array, value, firstIndex, secondIndex);
                }
                return -1;
            }
        }        
    }
}
