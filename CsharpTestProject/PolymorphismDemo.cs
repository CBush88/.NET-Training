using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class Mathematics
    {
        public void add()
        {
            int a, b;
            Console.WriteLine("Enter value for a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b: ");
            b = int.Parse(Console.ReadLine());

            int result = a + b;

            Console.WriteLine($"Addition is: {result}");
        }
        public void add(int b)
        {
            Console.WriteLine("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());

            int result = a + b;
            Console.WriteLine($"Addition of another method is: {result}");
        }
        public float add(float a, float b)
        {
            float result = a + b;
            return result;
        }
    }
    internal class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();

            math.add(); // simple add method
            math.add(23); // second add method
            Console.WriteLine($"Addition of two floating numbers is: {math.add(22.05f, 12.45f)}");
        }
    }
}
