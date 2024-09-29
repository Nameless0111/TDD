using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace STRINGTDD
{
    public class STRINGTdd
    {

        public string FindShortestWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            string res = null; 
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in words)
            {
                if (res == null || s.Length < res.Length) 
                {
                    res = s;
                }
            }

            return res;
        }

        public int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length; 
        }

        public int CountCharacters(string input)
        {
            return input?.Length ?? 0; 
        }

        public char? FindNinthCharacter(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 9)
                return null;

            return input[8]; 
        }

        public int CountDigits(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            int res = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    res++;
            }

            return res;
        }

        public int LongestDigits(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            int maxCount = 0, currentCount = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }

        public int CountAmOccurrences(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            int res = 0;

            while (true)
            {
                int index = input.IndexOf("ам");
                if (index >= 0)
                {
                    res++;
                    input = input.Substring(index + 2); 
                }
                else
                    break;
            }

            return res;
        }
    }
}
    

