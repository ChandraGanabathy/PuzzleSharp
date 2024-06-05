using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleSharp.String
{
    class StringPermuatation
    {
        static void Main(string[] args)
        {
            string input = "aba";
            var result = permutations(input);
            foreach (var item in result)
                Console.WriteLine(item);
            Console.ReadLine();
        }
        static List<string> permutations(string thisString)
        {
            List<string> myResult = new List<string>();
            if (thisString.Length <= 1)
            {
                myResult.Add(thisString);
            }
            else
            {
                for (int i = 0; i < thisString.Length; i++)
                {
                    IEnumerable<string> s = permutations(thisString.Substring(0, i) + thisString.Substring(i + 1))
                        .Select(x => thisString.Substring(i, 1) + x);
                    myResult.AddRange(s);
                }
            }
            return myResult;
        }
    }
}
