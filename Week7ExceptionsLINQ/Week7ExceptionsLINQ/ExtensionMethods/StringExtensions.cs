using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ExceptionsLINQ.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string MakeLastLetterUpperCase(this string input)
        {
            char[] chars = input.ToCharArray();
            chars[chars.Length - 1] = char.ToUpper(chars[chars.Length - 1]);

            return new string(chars);
        }

        public static string AppendLetter(this string input, string letter)
        {
            return input + letter;
        }

        public static bool IsPalindrom(this string input)
        {
            for(int index = 0; index < input.Length - 1; index++)
            {
                if (input[index] != input[input.Length - 1 - index])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
