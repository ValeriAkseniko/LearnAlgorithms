using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class StringAlgorithms
    {
        public static bool IsAnagram(string firstText, string secondText)
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

        static List<string> ListWords(string text)
        {
            text = text.ToLower();
            text = text.Trim();
            char[] chars = text.ToCharArray();
            chars = Array.FindAll<char>(chars, (c => (char.IsLetter(c)
                                              || char.IsWhiteSpace(c))));
            text = new string(chars);
            text = text.Replace("   ", "  ");
            text = text.Replace("  ", " ");
            List<string> words = text.Split(' ').ToList();
            return words;
        }

        public static Dictionary<string, int> GetWordStatistic(string text)
        {
            List<string> words = ListWords(text);
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                {words[0],words.Count}
            };
            return result;
        }
    }
}
