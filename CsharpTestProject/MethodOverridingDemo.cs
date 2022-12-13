using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class ParentClass
    {
        public virtual void Message()
        {
            Console.WriteLine("Hello from Parent class");
        }
    }
    class ChildClass: ParentClass 
    {
        public override void Message()
        {
            //base.Message();
            Console.WriteLine("Hello from child class");
        }
    }

    class PolyTest
    {
        public virtual void Test()
        {
            Console.WriteLine("Test from PolyTest class");
        }
    }

    class PolyChild: PolyTest
    {
        public override void Test() 
        { 
            Console.WriteLine("Test from PolyChild class");
        }
    }

    internal class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            //ChildClass child = new ChildClass();
            //child.Message();

            //ParentClass parent = new ChildClass();
            //parent.Message();

            //ParentClass p2 = new ParentClass();
            //p2.Message();

            PolyTest pt = new PolyTest();
            pt.Test();

            PolyChild pc = new PolyChild();
            pc.Test();

            PolyTest ptc = new PolyChild();
            ptc.Test();

            Console.ReadKey();
        }
    }
}
