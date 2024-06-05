using System;
using System.Collections.Generic;
namespace PuzzleSharp.String
{
    class FirstRepeatedWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine(firstrepeatedword("hi iam good hi"));
            Console.ReadLine();
        }
        static public string firstrepeatedword(string s)
        {
            var delims = new char[] { ' ', '\t', ',', '-', ':', ';' };
            string[] words = s.Split(delims);
            var hs = new HashSet<string>();
            foreach (var word in words)
            {
                if (!hs.Add(word.ToUpper()))
                    return word;
            }
            throw new Exception("No double word found");
        }
    }


}
