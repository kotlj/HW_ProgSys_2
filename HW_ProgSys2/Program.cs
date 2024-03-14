using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskStack
{
    class Task1
    {
        public static void task1()
        {
            string name = "TaskMgr";
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = $"{name}.exe";
            Process process = Process.Start(proc);

            process.WaitForExit();

            if (process.HasExited)
            {
                int endCode = process.ExitCode;
                Console.WriteLine($"End code: {endCode}");
            }
        }
    }

    class Task2
    {
        public static void task2()
        {
            string name = "Taskmgr";
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = $"{name}.exe";
            Process process = Process.Start(proc);

            Console.WriteLine("Choose:\n1 - wait till the end of process\n2 - kill process");
            char choise = (Console.ReadLine())[0];

            if (choise == '1')
            {
                process.WaitForExit();
                if (process.HasExited)
                {
                    Console.WriteLine($"End code: {process.ExitCode}");
                }
            }
            else
            {
                Console.WriteLine("You are monster!");
                process.Kill();
            }
        }
    }
}

namespace HW_ProgSys2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choise = '0';
            while(true)
            {
                Console.WriteLine("choose:\n1 - task1\n2 - task2\n0 - exit");
                choise = (Console.ReadLine())[0];
                if (choise == '1')
                {
                    TaskStack.Task1.task1();
                }
                else if (choise == '2')
                {
                    TaskStack.Task2.task2();
                }
                else if (choise == '0')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: unknow option");
                }
            }
        }
    }
}
