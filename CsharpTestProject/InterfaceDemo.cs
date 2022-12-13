using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CsharpTestProject
{
    
    interface IMath
    {
        // any properties considered constants
        void add();
    }
    interface ICalci
    {
        void sub();
    }
    class Demo : IMath, ICalci
    {
        public void add() 
        {
            Console.WriteLine("This is addition from Interface IMath");
        }
        public void sub() 
        { 
            Console.WriteLine("This is subtraction from Interface ICalci");
        }
    }
    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.add();
            d.sub();
            Console.ReadKey();
        }
    }
}
