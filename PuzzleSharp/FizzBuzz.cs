using System;
namespace PuzzleSharp
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + "FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine(i + "Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine(i + "Buzz");
            }
            Console.ReadLine();
        }
    }
}
