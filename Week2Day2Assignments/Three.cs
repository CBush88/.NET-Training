using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Assignments
{
    //Create a program to implement Multilevel inheritance using interfaces
    interface IPrint3 : IPrint, IPrint2
    {
        void Print3();
    }
    class Implementer3: IPrint3
    {
        public void Print()
        {
            Console.WriteLine("Implementation of Print");
        }
        public void Print2()
        {
            Console.WriteLine("Implementation of Print 2");
        }
        public void Print3()
        {
            Console.WriteLine("Implementation of Print 3");
        }
    }
    internal class Three
    {
        static void Main(string[] args)
        {
            Implementer3 implementer = new Implementer3();
            implementer.Print();
            implementer.Print2();
            implementer.Print3();
        }
    }
}
