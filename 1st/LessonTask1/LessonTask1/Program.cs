using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите ваше имя:");
            string username = Console.ReadLine();

            Console.WriteLine($"Привет, {username}, сегодня {DateTime.Now.ToString("d")}");
        }
    }
}
