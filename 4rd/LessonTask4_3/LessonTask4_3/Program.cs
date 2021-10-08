using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask4_3
{
    class Program
    {
        [Flags]
        public enum YearTimes
        {
            Unknown,
            Winter,
            Spring,
            Summer,
            Autumn,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input month number in order:");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            GetRUYearTime(GetYearTime(monthNum));

        }

        static YearTimes GetYearTime(int monthNum)
        {
            switch (monthNum)
            {
                case 12:
                case 1: 
                case 2:
                    return YearTimes.Winter;
                case 3:
                case 4:
                case 5:
                    return YearTimes.Spring;
                case 6:
                case 7:
                case 8:
                    return YearTimes.Summer;
                case 9:
                case 10:
                case 11:
                    return YearTimes.Autumn;
                default:
                    Console.WriteLine("Error. Please input number between 1 and 12.");
                    return YearTimes.Unknown;
            }
        }

        static void GetRUYearTime(YearTimes yTime)
        {
            switch (yTime)
            {
                case YearTimes.Winter:
                    Console.WriteLine("Зима");
                    break;
                case YearTimes.Spring:
                    Console.WriteLine("Весна");
                    break;
                case YearTimes.Summer:
                    Console.WriteLine("Лето");
                    break;
                case YearTimes.Autumn:
                    Console.WriteLine("Осень'");
                    break;
                default:
                    break;

            }
        }

    }
}
