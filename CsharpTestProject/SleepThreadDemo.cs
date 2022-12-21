using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsharpTestProject
{
    internal class SleepThreadDemo
    {
        static void Function1()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread} Started");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread} Finished");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Function1);
            t.Name = "Thread 1";
            t.IsBackground = false;
            t.Start();
            Console.WriteLine("Main Thread is running");
            Console.ReadKey();
        }
    }
}
