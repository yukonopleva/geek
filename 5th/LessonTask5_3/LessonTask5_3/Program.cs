using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input numbers between 0 and 255 using ' ' as separator:");
            string numbers = Console.ReadLine();

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), numbers);
        }
    }
}
