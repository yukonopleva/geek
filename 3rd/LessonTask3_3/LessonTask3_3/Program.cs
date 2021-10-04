using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input word:");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }

            Console.Write("\n");
        }
    }
}
