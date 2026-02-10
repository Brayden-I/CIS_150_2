using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities.Tools
{
    public static class Tools
    {
        public static string ReverseString(string String)
        {
            string str = String;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            string result = new string(charArray);
            return result;
        }

        public static bool IsPalindrome(string String)
        {
            if (string.IsNullOrEmpty(String)) //Returns false on empty strings
            {
                return false;
            }

            string reverseStr = ReverseString(String);

            return reverseStr == String; //Return the bool accordingly
        }

        public static int CountVowels(string String)
        {
            string str = String.ToLower(); //ToLower for ease
            char[] charArray = str.ToCharArray();

            int count = 0;

            foreach (char Char in charArray)
            {
                if (Char == 'a' || Char == 'e' || Char == 'i' || Char == 'o' || Char == 'u') //Vowels
                {
                    count++;
                }
            }

            return count;
        }
    }
}
