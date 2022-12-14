using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CsharpTestProject
{
    internal class CollectionDemo
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(100);
            st.Push("Chris");
            st.Push(".Net");
            
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            Console.WriteLine("After Pop");
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>();
            names.Add("Chris");
            names.Add("Bob");

            foreach(var name in names)
            {
                Console.WriteLine("Name is: " + name);
            }

            names.Remove("Bob");

            Console.WriteLine("After Remove");

            foreach(string name in names)
            {
                Console.WriteLine("Name is: " + name);
            }

            List<int> ints = new List<int>(new[] { 1, 3, 5, 7, 9 });
            int[] a = { 1, 2, 3, 4 };
            List<int> ints2 = a.ToList<int>();

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            foreach(int i in ints2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(ints2.Average());

            Console.ReadKey();
        }
    }
}
