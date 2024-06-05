/*
==========================================================================================================
This site should print a matrix (n x m) on the screen and be able to do some processing of the Matrix.  Follow these requirements in building the site.
1.	Create a Console Application called InterviewMatrix
2.	When starting, it should take the following command line arguments: 
a.	Matrix Width (w)
b.	Matrix Height (h)
c.	Traverse type
i.	Top-to-Bottom should be the only accepted value
3.	When executed, the program should build w x h matrix populated with alpha characters, and then display the contents of that matrix by traversing each column in a row from left to right, and the moving down each row from top to bottom.  The contents of each [w,h] position should be outputted to the screen as you are traversing the matrix. 

**Note – If the matrix is larger than 26 elements, start back at A to continue populating the matrix.

Example:
Command line would look like:  InterviewMatrix.exe -width 3 -height 4 -traverse toptobottom
The matrix built should look like:  
A	B	C
D	E	F
G	H	I
J	K	L

Output would be:  A, B, C, D, E, F, G, H, I, J, K, L
=============================================================================================================
*/
using System;
namespace PuzzleSharp
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int row = 4; int col = 10;
            char[,] matrix = new char[row, col];

            int alphaNumber = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = (char)('A' + alphaNumber % 26);
                    alphaNumber++;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


}

