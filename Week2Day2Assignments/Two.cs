using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Assignments
{
    //write a program to implement Multiple Inheritance using two interfaces
    interface IPrint2
    {
        void Print2();
    }
    class Implementer2: IPrint, IPrint2
    {
        public void Print()
        {
            Console.WriteLine("Implementation of IPrint.");
        }
        public void Print2()
        {
            Console.WriteLine("Implementation if IPrint2.");
        }
    }
    internal class Two
    {
        static void Main(string[] args)
        {
            Implementer2 implementer = new Implementer2();

            implementer.Print();
            implementer.Print2();
        }
    }
}
