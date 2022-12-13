using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Assignments
{

    //Write a program to create and use interface in a class using inheritance.
    interface IPrint
    {
        void Print();
    }
    class Implementer: IPrint
    {
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }

    class One
    {
        static void Main(string[] args)
        {
            Implementer implementer = new Implementer();
            implementer.Print();
        }
    }
}
