using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask5_5
{
    class Program
    {
        [Serializable]
        public class ToDo
        {
            public int IsDone { get; set; }
            public string Title { get; set; }

            public ToDo(int isDone, string title)
            {
                IsDone = isDone;
                Title = title;
            }
        }

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ykonople\Desktop\Useful Programms\Personal\Repository\5th\LessonTask5_5\LessonTask5_5\bin\Debug\tasks.bin";
            ToDo firTask = new ToDo(1, "Create a letter");
            ToDo secTask = new ToDo(0, "Make a deploy");
            ToDo thiTask = new ToDo(0, "Call mom");
            ToDo[] tasks = new ToDo[] { firTask, secTask, thiTask };
            ToDo[] taskList = new ToDo[] { };

            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    ToDo[] staskList = (ToDo[])formatter.Deserialize(fs);
                    taskList = staskList;
                }
                 
                for (int i = 1; i <= taskList.GetLength(0); i++)
                    if (taskList[i-1].IsDone == 1)
                        Console.WriteLine($"[X] {i}. {taskList[i-1].Title}");
                    else
                        Console.WriteLine($"    {i}. {taskList[i-1].Title}");

                int j = 1;
                while (j != 0)
                {
                    Console.WriteLine("Please input task number or 0 to exit:");
                    j = Convert.ToInt32(Console.ReadLine());

                    if (j == 0)
                        break;
                    else 
                    {
                        taskList[j - 1].IsDone = 1;

                        for (int i = 1; i <= taskList.GetLength(0); i++)
                            if (taskList[i - 1].IsDone == 1)
                                Console.WriteLine($"[X] {i}. {taskList[i - 1].Title}");
                            else
                                Console.WriteLine($"    {i}. {taskList[i - 1].Title}");
                    }
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    formatter.Serialize(fs, taskList);
                }
            }
            else
            {
                formatter.Serialize(new FileStream(filePath, FileMode.Create), tasks);
            }
        }
    }

}
