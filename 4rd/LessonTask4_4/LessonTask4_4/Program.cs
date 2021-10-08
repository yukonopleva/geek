using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 1;

            GetNumFact(n, i, j);

        }

        static void GetNumFact(int n, int i, int j)
        {
            int s = 0;

            if (n == 0 || (i + j) > n)
                Console.WriteLine(j);
            else
            {
                s = i + j;
                GetNumFact(n, i = j, j = s);
            }

        }
    }
}
