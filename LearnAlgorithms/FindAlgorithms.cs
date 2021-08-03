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
                if (midle > value)
                {
                    return BinarySearch(array, value, firstIndex, result);
                    
                }
                else
                {
                    return BinarySearch(array, value, result, secondIndex);
                }
            }

        }
        public static int BinarySearch(int[] array, int value, int firstIndex, int secondIndex)
        {
            if (firstIndex > secondIndex)
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
                if (midle > value)
                {
                    return BinarySearch(array, value, firstIndex, result - 1);
                }
                else 
                {
                    return BinarySearch(array, value, result + 1, secondIndex);
                }
            }
        }        
    }
}
