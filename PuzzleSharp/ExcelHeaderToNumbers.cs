using System;

namespace PuzzleSharp
{
    class ExcelHeaderToNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(generateColumnIndex("AC"));
            Console.ReadLine();
        }
        static public int generateColumnIndex(string columnName)
        {
            int str_length = columnName.Length;
            if (str_length == 0) return 0;
            char first_ele = columnName.ToCharArray()[0];
            if (str_length == 1)
            {
                return first_ele - 'A' + 1;
            }

            int sum = (int)(Math.Pow(26, str_length - 1)) * (first_ele - 'A' + 1);
            sum += columnName.Length > 1 ? generateColumnIndex(columnName.Substring(1)) : generateColumnIndex(columnName);
            return sum;
        }
    }
    

}
