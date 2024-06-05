using System;
namespace PuzzleSharp.String
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            FirstMethod("Amma m");
            Console.ReadLine();
        }
        public static bool FirstMethod(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
        public static bool IsPalindrome(string str)
        {
            int len = str.Length - 1;

            return str[0] == str[len] && (
                   len <= 1 || IsPalindrome(str.Substring(1, len))
                   );
        }
    }
    

}
