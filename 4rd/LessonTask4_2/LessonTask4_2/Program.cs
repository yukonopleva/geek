using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input numbers separated by space:");
            string numbers = Console.ReadLine();

            Console.WriteLine($"Sum of numbers: {GetNumSum(numbers)}");
        }

        static int GetNumSum(string numbers)
        {
            string[] nums = numbers.Split(' ');
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
                sum = sum + Convert.ToInt32(nums[i]);

            return sum;
        }
    }
}
