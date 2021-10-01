using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currData = new DateTime(2021, 9, 30, 10, 28, 42);
            int positNum = 1;
            decimal positCost = 980.00M;
            decimal persMoney = 1000.00M;
            int kassirNum = 1;
            int checkNum = 25;

            //Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("     НОВЫЙ ЧЕК     ");
            Console.WriteLine("     АМС-100к      ");
            Console.WriteLine(" ИНН. 007700000000 ");
            Console.WriteLine("    НМ 20547316    ");
            Console.WriteLine("      КЛ 0196      ");
            Console.WriteLine($"{currData.ToString("d")}    {currData.ToString("HH:mm")}");
            Console.WriteLine("-------------------");
            Console.WriteLine($" {positNum}     {positCost}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"ИТОГ*********{positCost}");
            Console.WriteLine($"НАЛИЧ       {persMoney}");
            Console.WriteLine($"СДАЧА         {persMoney - positCost}");
            Console.WriteLine("     СПАСИБО!     ");
            Console.WriteLine($"КАССИР {kassirNum}  ЧЕК  {checkNum.ToString("0000")}");
            Console.WriteLine("*ПФП  000000005050*");
            Console.WriteLine("    ЭКЛЗ 2699573369");
            Console.WriteLine("   00009972 #044887");
        }
    }
}
