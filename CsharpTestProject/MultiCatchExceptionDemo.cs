using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class MultiCatchExceptionDemo
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            try
            {
                Console.WriteLine("Enter First Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine("Division result is: " + result);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Second number should not be zero.");
                Console.WriteLine(de.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Enter only integer numbers.");
                Console.WriteLine(fe.Message);
            }
            Console.ReadKey();

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter a number, up to 10");
            int num = int.Parse(Console.ReadLine());
            try
            {
                for(int i = 0; i < num; i ++)
                {
                    Console.WriteLine(ints[i]);
                }
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("Your number was too large.");
                Console.WriteLine(ie.Message);
            }
        }
    }
}
