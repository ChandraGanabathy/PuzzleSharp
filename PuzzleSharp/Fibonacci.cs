using System;
namespace PuzzleSharp
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(7));
            Console.ReadLine();
        }
        static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (fibonacci(n - 1) + fibonacci(n - 2));
        }
    }


}
