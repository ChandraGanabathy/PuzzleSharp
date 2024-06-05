using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleSharp.String
{
    class SortedArrayOccurance
    {
        static void Main(string[] args)
        {
            char[] input = "aaabbcdffffffffffff".ToCharArray();
            var _occurence = new Occurence(input);
            _occurence.CountOccurence(0, input.Length - 1);
            _occurence.DisplayAnswer();
            Console.ReadLine();
        }
        public class Occurence
        {
            private char[] givenSortedArray;
            private Dictionary<char, int> dict;

            public Occurence(char[] letters)
            {
                givenSortedArray = letters;
                dict = new Dictionary<char, int>();
            }
            public void CountOccurenceOrderofN(int LeftIndex, int RightIndex)
            {
                var Diff = RightIndex - LeftIndex;
                if (givenSortedArray[LeftIndex] == givenSortedArray[RightIndex])
                {
                    if (!dict.Keys.Contains(givenSortedArray[LeftIndex]))
                    {
                        dict.Add(givenSortedArray[LeftIndex], Diff + 1);
                    }
                    else
                    {
                        dict[givenSortedArray[LeftIndex]] += Diff + 1;
                    }
                }
                else
                {
                    var HalfDiff = Math.Abs(Diff / 2);
                    CountOccurence(LeftIndex, LeftIndex + HalfDiff);
                    CountOccurence(LeftIndex + HalfDiff + 1, RightIndex);
                }
            }
            public void CountOccurence(int LeftIndex, int RightIndex)
            {
                var Diff = RightIndex - LeftIndex;
                if (givenSortedArray[LeftIndex] == givenSortedArray[RightIndex])
                {
                    if (!dict.Keys.Contains(givenSortedArray[LeftIndex]))
                    {
                        dict.Add(givenSortedArray[LeftIndex], Diff + 1);
                    }
                    else
                    {
                        dict[givenSortedArray[LeftIndex]] += Diff + 1;
                    }
                }
                else
                {
                    var HalfDiff = Math.Abs(Diff / 2);
                    CountOccurence(LeftIndex, LeftIndex + HalfDiff);
                    CountOccurence(LeftIndex + HalfDiff + 1, RightIndex);
                }
            }

            public void DisplayAnswer()
            {
                foreach (var item in dict)
                {
                    Console.WriteLine(item.Key.ToString() + "-" + item.Value);
                }
            }
        }
    }


}
