using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string workDir = @"C:\Users\ykonople\Desktop\Useful Programms\Personal\Repository\5th\LessonTask5_4";
            string fileName = "directory.txt";

            File.WriteAllLines(fileName, new[] { workDir });

            GetDirectoryTree(workDir, fileName);
            GetFiles(workDir, fileName);
        }

        static void GetDirectoryTree(string workDir, string fileName)
        {
            string[] dirArray = Directory.GetDirectories(workDir);

            for (int i = 0; i < dirArray.Length; i++)
            {
                File.AppendAllLines(fileName, new[] { dirArray[i] });
                if (Directory.GetDirectories(dirArray[i]).Length > 0)
                {
                    
                    GetDirectoryTree(dirArray[i], fileName);
                    GetFiles(dirArray[i], fileName);
                    
                }
                else
                {
                    GetFiles(dirArray[i], fileName);
                }

            }

        }

        static void GetFiles(string filePath, string fileName)
        {
            string[] filesArray = Directory.GetFiles(filePath);

            for (int j = 0; j < filesArray.Length; j++)
                File.AppendAllLines(fileName, new[] { filesArray[j] });
        }
    }
}
