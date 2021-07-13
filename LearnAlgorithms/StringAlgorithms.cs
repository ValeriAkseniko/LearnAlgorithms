using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class StringAlgorithms
    {
        public static bool IsAnagram(string firstText,string secondText)
        {
            char[] firstArray = ((firstText.ToLower()).ToCharArray());
            char[] secondArray = ((secondText.ToLower()).ToCharArray());
            Array.Sort(firstArray);
            Array.Sort(secondArray);
            string firstWord = new string(firstArray);
            string secondWord = new string(secondArray);
            if (firstWord == secondWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPalindrom(string text)
        {
            text = text.ToLower();
            for (int i = 0, j = text.Length - 1; i < text.Length / 2; i++, j--)
            {
                if (text[i] != text[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
