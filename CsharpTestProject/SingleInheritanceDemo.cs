using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class Parent1
    {
        public void parent1()
        {
            Console.WriteLine("This is Parent1 class");
        }
    }
    class Child1 : Parent1 
    {
        public void child1()
        {
            Console.WriteLine("This is Child1 class");
        }
    }
    internal class SingleInheritanceDemo
    {
    static void Main(string[] args)
    {
            Child1 ch = new Child1();
            ch.child1();
            ch.parent1();
            Console.ReadKey();
    }

    }
}
