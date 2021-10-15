using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] procByName = new Process[] { };
            Process procById = new Process();
            int an = 1;
            

            while(an != 0)
            {
                GetCurrProc();
                string message = "Do you wish to kill any process? 0 - No, 1 - Yes";
                an = CheckInputData(message);

                if (an == 1)
                {
                    message = "Do you wish to kill process by Name or by Id? 0 - By Name, 1 - By Id";
                    int answer = CheckInputData(message);

                    if (answer == 0)
                    {
                        Console.WriteLine("Please input name of the process:");
                        string procName = Console.ReadLine();

                        try
                        {
                            procByName = Process.GetProcessesByName(procName, "EURMOODXH91N2");
                        }
                        catch 
                        {
                            Console.WriteLine("Something went wrong");
                            break;
                        }

                        for (int i = 0; i < procByName.GetLength(0); i++)
                            procByName[i].Kill();
                    }
                    else

                    if (answer == 1)
                    {
                        message = "Please input Id of the process:";
                        int procId = CheckInputData(message);

                        try
                        {
                            procById = Process.GetProcessById(procId, "EURMOODXH91N2");
                            procById.Kill();
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("ProcessID is not performed");
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong");
                            break;
                        }                        
                        
                    }

                    else
                        Console.WriteLine("Wrong value");
                }

                else

                 if (an == 0)
                    break;

                else
                    Console.WriteLine("Wrong value");
            }

        }

        static void GetCurrProc()
        {
            Process[] proc = Process.GetProcesses();

            Console.WriteLine("All current processes:");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Process Name                                                         Id");
            Console.WriteLine("=======================================================================");
            for (int i = 0; i < proc.GetLength(0); i++)
                Console.WriteLine("{0, -50} {1, 20}", $"{proc[i].ProcessName}", $"{proc[i].Id}");
        }

        static int CheckInputData(string message)
        {
            int an;
            while (true)
            {
                Console.WriteLine(message);
                try
                {
                    an = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong value");
                }
            }
            return an;
        }
    }
}
