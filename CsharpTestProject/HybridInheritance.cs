using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public class GreatGrandParent
    {
        public void GGp()
        {
            Console.WriteLine("Great GrandParent Method");
        }
    }
    public class GrandParent : GreatGrandParent
    {
        public void Gp()
        {
            Console.WriteLine("GrandParent Method");
        }
    }
    public class Parent2:GrandParent
    {
        public void parent2()
        {
            Console.WriteLine("Parent Method");
        }
    }
    interface IExtra
    {
        void Extra();
    }
    public class BottomChild:Parent2, IExtra
    {
        public void bottomChild()
        {
            Console.WriteLine("Bottom Child Method");
        }
        public void Extra()
        {
            Console.WriteLine("Extra Interface Method");
        }
    }
    internal class HybridInheritance
    {
        static void Main(string[] args)
        {
            BottomChild child = new BottomChild();
            child.GGp();
            child.Gp();
            child.parent2();
            child.Extra();
            child.bottomChild();
        }
    }
}

