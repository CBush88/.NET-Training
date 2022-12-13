using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class Simple
    {
        public void Display()
        {
            Console.WriteLine("Display method of class simple");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Program in C#");
            Simple n = new Simple();
            n.Display();
            Console.ReadKey();
        }
    }
}
