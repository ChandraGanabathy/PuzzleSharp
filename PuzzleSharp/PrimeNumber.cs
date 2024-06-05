using System;
namespace PuzzleSharp
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(7));
            Console.ReadLine();
        }
        static public bool IsPrime(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
    

}
