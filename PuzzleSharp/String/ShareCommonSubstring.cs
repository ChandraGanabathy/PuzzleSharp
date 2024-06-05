using System;
namespace PuzzleSharp.String
{
    class ShareCommonSubstring
    {
        /*
        Given two strings, determine if they share a common substring. A substring may be as small as one character.
        * Complete the 'twoStrings' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts following parameters:
        *  1. STRING s1
        *  2. STRING s2
        */
        static void Main(string[] args)
        {
            string s1 = "hello";

            string s2 = "world";

            string result = twoStrings(s1, s2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string twoStrings(string s1, string s2)
        {
            int length = s2.Length;
            foreach (var element in s1)
            {
                int matchCount = 0;
                while (matchCount <= length - 1)
                {
                    if (element.CompareTo(s2[matchCount]) == 0)
                        return "YES";
                    matchCount++;
                }

            }
            return "NO";
        }
    }
}
//Given two strings, determine if they share a common substring. A substring may be as small as one character.

//Example


//These share the common substring .



//These do not share a substring.

//Function Description

//Complete the function twoStrings in the editor below.

//twoStrings has the following parameter(s):

//string s1: a string
//string s2: another string
//Returns

//string: either YES or NO
//Input Format

//The first line contains a single integer , the number of test cases.

//The following  pairs of lines are as follows:

//The first line contains string .
//The second line contains string .
//Constraints

// and  consist of characters in the range ascii[a-z].
//Output Format

//For each pair of strings, return YES or NO.

//Sample Input

//2
//hello
//world
//hi
//world
//Sample Output

//YES
//NO
//Explanation

//We have  pairs to check:

//, . The substrings  and  are common to both strings.
//, .  and  share no common substrings.Given two strings, determine if they share a common substring. A substring may be as small as one character.

//Example


//These share the common substring .



//These do not share a substring.

//Function Description

//Complete the function twoStrings in the editor below.

//twoStrings has the following parameter(s):

//string s1: a string
//string s2: another string
//Returns

//string: either YES or NO
//Input Format

//The first line contains a single integer , the number of test cases.

//The following  pairs of lines are as follows:

//The first line contains string .
//The second line contains string .
//Constraints

// and  consist of characters in the range ascii[a-z].
//Output Format

//For each pair of strings, return YES or NO.

//Sample Input

//2
//hello
//world
//hi
//world
//Sample Output

//YES
//NO
//Explanation

//We have  pairs to check:

//, . The substrings  and  are common to both strings.
//, .  and  share no common substrings.