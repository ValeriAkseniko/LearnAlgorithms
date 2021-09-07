using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithms
{
    static class StringAlgorithms
    {
        const string RusChars = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        const string EngChars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        static bool IsRusLetter(char symbol)
        {
            if (!RusChars.Contains(symbol))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool IsEngLetter(char symbol)
        {
            if (!EngChars.Contains(symbol))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
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
            chars = Array.FindAll<char>(chars, (c => (IsRusLetter(c)
                                              || IsEngLetter(c) 
                                              || char.IsWhiteSpace(c))));
            text = new string(chars);
            while (text.Contains("  "))
            {
                text.Replace("  ", " ");
            }
            List<string> words = text.Split(' ').ToList();
            return words;
        }

        public static Dictionary<string, int> GetWordStatistic(string text)
        {
            List<string> words = ListWords(text);
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
                if (!result.ContainsKey(words[i]))
                {
                    result.Add(words[i], 1);
                }
                else
                {
                    result[words[i]]++;                    
                }
            }
            return result;
        }
    }
}
