using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsharpTestProject
{
    internal class ThreadBehaviorDemo
    {
        public static void PrintThread1()
        {
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Thread 1 for {i}");
                //Thread.Sleep(1);
            }
        }
        public static void PrintThread2()
        {
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Thread 2 for {i}");
                //Thread.Sleep(1);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintThread1);
            Thread t2 = new Thread(PrintThread2);
            Console.WriteLine("Thread started: ");

            t1.Start();
            Thread.Sleep(100); //Enough delay to complete thread 1 first
            t2.Start();

            Console.ReadKey();
        }
    }
}
