using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public class Parent
    {
        public void Test()
        {
            Console.WriteLine("This demonstrates inheritance from a parent class.");
        }
    }
    interface ITest
    {
        void InterfaceTest();
    }
    class Child: Parent, ITest
    {
        public void InterfaceTest()
        {
            Console.WriteLine("This demonstrates inheritance from an interface.");
        }
    }
    internal class MultipleInheritance2
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Test();
            child.InterfaceTest();
        }
    }
}
