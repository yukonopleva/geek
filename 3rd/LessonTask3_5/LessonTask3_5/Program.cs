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
            Console.WriteLine("Please input string:");
            string str = Console.ReadLine();

            string str1 = "";
            string str2 = "";
            string maxStr = "";
            int maxLen = 0;

            if (str.Length == 1)
            {
                Console.WriteLine($"Max palindrome: {str}");
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                    for (int j = i + 1; j < str.Length; j++)
                        if (str[i] == str[j])
                        {
                            str1 = "";
                            str2 = "";
                            for (int k = i; k <= j; k++)
                                str1 = str1 + str[k];

                            for (int l = j; l >= i; l--)
                                str2 = str2 + str[l];

                            if (str1 == str2)
                                if (str1.Length > maxLen)
                                {
                                    maxLen = str1.Length;
                                    maxStr = str1;
                                }

                        }
                Console.WriteLine($"Max palindrome: {maxStr}");
            }
        }
    }
}
