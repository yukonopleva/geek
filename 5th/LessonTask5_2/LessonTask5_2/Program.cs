using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";
            string dateTime = Convert.ToString(DateTime.Now.ToLongTimeString());
            
            File.AppendAllLines(fileName, new[] { dateTime });
        }
    }
}
