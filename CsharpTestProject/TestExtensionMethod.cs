using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyExtensionMethod;
using Extension2;

namespace CsharpTestProject
{
    public static class ExtClass
    {
        public static void NewExtMethod(this Class1 ob)
        {
            Console.WriteLine("This is extension method");
        }
    }

    public static class Extension2Class
    {
        public static void Ext2Method(this Class2 ob2)
        {
            Console.WriteLine("This is another extended method");
        }
    }
    internal class TestExtensionMethod
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            Console.WriteLine(ob.Display());
            Console.WriteLine(ob.Print());
            ob.NewExtMethod();
            Console.ReadKey();

            Console.WriteLine();

            Class2 ob2 = new Class2();
            Console.WriteLine(ob2.Test());
            ob2.Ext2Method();
        }
    }
}
