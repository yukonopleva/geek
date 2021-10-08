using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName1 = "Ivan";
            string lastName1 = "Ivanov";
            string patronymic1 = "Ivanovich";

            Console.WriteLine(GetFullName(firstName1, lastName1, patronymic1));

            string firstName2 = "Petr";
            string lastName2 = "Petrov";
            string patronymic2 = "Petrovich";

            Console.WriteLine(GetFullName(firstName2, lastName2, patronymic2));

            string firstName3 = "Aleksandr";
            string lastName3 = "Aleksandrov";
            string patronymic3 = "Aleksandrovich";

            Console.WriteLine(GetFullName(firstName3, lastName3, patronymic3));
        }

            public static string GetFullName(string firstName, string lastName, string patronymic)
        { 
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
    }
}
