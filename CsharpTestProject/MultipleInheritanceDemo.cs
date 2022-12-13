using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class Calculator
    {
        public void multi()
        {
            Console.WriteLine("This is multi method from class Calculator");
        }
    }
    //Always put class first
    class Calc : Calculator, IMath
    {
        public void add()
        {
            Console.WriteLine("Calling add method from IMath");
        }
    }
    internal class MultipleInheritanceDemo
    {
        static void Main(string[] args)
        {
            Calc ca = new Calc();
            ca.add();
            ca.multi();
        }
    }
}
