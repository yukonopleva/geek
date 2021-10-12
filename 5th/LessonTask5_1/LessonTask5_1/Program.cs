using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input your text:");
            string filename = "text.txt";

            File.WriteAllText(filename, Console.ReadLine());
        }
    }
}
