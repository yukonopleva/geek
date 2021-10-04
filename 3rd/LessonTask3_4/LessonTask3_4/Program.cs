using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[10, 10];
            array[0, 0] = 'O';
            array[0, 1] = 'O';
            array[0, 2] = 'O';
            array[0, 3] = 'O';
            array[0, 4] = 'O';
            array[0, 5] = 'O';
            array[0, 6] = 'O';
            array[0, 7] = 'X';
            array[0, 8] = 'X';
            array[0, 9] = 'O';
            array[1, 0] = 'O';
            array[1, 1] = 'X';
            array[1, 2] = 'O';
            array[1, 3] = 'O';
            array[1, 4] = 'X';
            array[1, 5] = 'O';
            array[1, 6] = 'O';
            array[1, 7] = 'O';
            array[1, 8] = 'O';
            array[1, 9] = 'O';
            array[2, 0] = 'O';
            array[2, 1] = 'O';
            array[2, 2] = 'O';
            array[2, 3] = 'O';
            array[2, 4] = 'X';
            array[2, 5] = 'O';
            array[2, 6] = 'O';
            array[2, 7] = 'O';
            array[2, 8] = 'X';
            array[2, 9] = 'O';
            array[3, 0] = 'O';
            array[3, 1] = 'O';
            array[3, 2] = 'O';
            array[3, 3] = 'O';
            array[3, 4] = 'O';
            array[3, 5] = 'O';
            array[3, 6] = 'O';
            array[3, 7] = 'O';
            array[3, 8] = 'O';
            array[3, 9] = 'O';
            array[4, 0] = 'O';
            array[4, 1] = 'O';
            array[4, 2] = 'O';
            array[4, 3] = 'O';
            array[4, 4] = 'O';
            array[4, 5] = 'O';
            array[4, 6] = 'X';
            array[4, 7] = 'X';
            array[4, 8] = 'X';
            array[4, 9] = 'O';
            array[5, 0] = 'X';
            array[5, 1] = 'O';
            array[5, 2] = 'X';
            array[5, 3] = 'O';
            array[5, 4] = 'O';
            array[5, 5] = 'O';
            array[5, 6] = 'O';
            array[5, 7] = 'O';
            array[5, 8] = 'O';
            array[5, 9] = 'O';
            array[6, 0] = 'X';
            array[6, 1] = 'O';
            array[6, 2] = 'X';
            array[6, 3] = 'O';
            array[6, 4] = 'O';
            array[6, 5] = 'O';
            array[6, 6] = 'O';
            array[6, 7] = 'O';
            array[6, 8] = 'O';
            array[6, 9] = 'O';
            array[7, 0] = 'O';
            array[7, 1] = 'O';
            array[7, 2] = 'X';
            array[7, 3] = 'O';
            array[7, 4] = 'O';
            array[7, 5] = 'O';
            array[7, 6] = 'X';
            array[7, 7] = 'O';
            array[7, 8] = 'O';
            array[7, 9] = 'O';
            array[8, 0] = 'O';
            array[8, 1] = 'O';
            array[8, 2] = 'X';
            array[8, 3] = 'O';
            array[8, 4] = 'O';
            array[8, 5] = 'O';
            array[8, 6] = 'X';
            array[8, 7] = 'O';
            array[8, 8] = 'O';
            array[8, 9] = 'X';
            array[9, 0] = 'X';
            array[9, 1] = 'O';
            array[9, 2] = 'O';
            array[9, 3] = 'O';
            array[9, 4] = 'O';
            array[9, 5] = 'O';
            array[9, 6] = 'X';
            array[9, 7] = 'O';
            array[9, 8] = 'O';
            array[9, 9] = 'O';
            int k = 0;
            Console.WriteLine("   ABCDEFGHIJ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                k++;
                if (k < 10)
                    Console.Write($"{k}  ");
                else
                    Console.Write($"{k} ");

                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j]);
                Console.Write("\n");
            }
        }
    }
}
