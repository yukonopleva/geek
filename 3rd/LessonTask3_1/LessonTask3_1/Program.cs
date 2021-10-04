using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3];
            array[0, 0] = 5;
            array[0, 1] = 4;
            array[0, 2] = 4;
            array[1, 0] = 7;
            array[1, 1] = 1;
            array[1, 2] = 1;
            int j = 0;

            for (int i = 0; i < array.GetLength(0) & j < array.GetLength(1); i++, j++)
            {
                Console.WriteLine(array[i, j]);
            }
        }

    }
}
