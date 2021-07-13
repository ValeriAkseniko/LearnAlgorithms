using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class StringAlgorithms
    {
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
