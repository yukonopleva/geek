using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask2_1
{
    class Program
    {
       public enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите максимальную дневную температуру:");
            float maxTemp = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальную дневную температуру:");
            float minTemp = float.Parse(Console.ReadLine());

            float avrTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Средняя суточная температура: {avrTemp}");

            Console.WriteLine("Введите порядковый номер текущего месяца:");
            int currMonth = int.Parse(Console.ReadLine());

            Months month = (Months)currMonth;

            Console.WriteLine($"{month}");

            if ((currMonth == 1 || currMonth == 2 || currMonth == 12) && avrTemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            

    }
    }
}
