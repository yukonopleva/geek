using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2];
            array[0, 0] = "Ivanov";
            array[0, 1] = "89640123456/Ivanov@mail.ru";
            array[1, 0] = "Petrov";
            array[1, 1] = "89030127756/Petrov@mail.ru";
            array[2, 0] = "Smirnov";
            array[2, 1] = "89050987756/Smirnov@mail.ru";
            array[3, 0] = "Kozlov";
            array[3, 1] = "89640927756/Kozlov@mail.ru";
            array[4, 0] = "Oslov";
            array[4, 1] = "89110127756/Oslov@mail.ru";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}
