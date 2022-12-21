using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsharpTestProject
{
    internal class SimpleThreadDemo
    {
        static void MyFunc()
        {
            Console.WriteLine("Running other thread");
        }

        static void MyFunc2()
        {
            Console.WriteLine(30 + 50);
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(MyFunc);
            t.Start();
            Thread t2 = new Thread(MyFunc2);
            t2.Start();
            Console.WriteLine("Main Thread Running");
            Console.ReadKey();
        }
    }
}
