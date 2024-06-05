using System;

namespace PuzzleSharp.String
{
    class StringsearchNaive
    {
        static void Main(string[] args)
        {
            string toFind = "chandra";
            string toSearch = "this is chandra";
            Console.WriteLine(search(toFind, toSearch));
        }
        static bool search(string toFind, string toSearch)
        {
            for (int startIndex = 0; startIndex <= toSearch.Length - toFind.Length; startIndex++)
            {
                int matchCount = 0;
                while (toFind[matchCount].CompareTo(toSearch[startIndex + matchCount]) == 0)
                {
                    matchCount++;
                    if (toFind.Length == matchCount)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
