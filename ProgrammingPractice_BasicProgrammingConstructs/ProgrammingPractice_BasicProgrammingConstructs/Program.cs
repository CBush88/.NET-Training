using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice_BasicProgrammingConstructs
{
//    int num1, num2;
//    Console.Write("Enter first number :: "); 
//num1 = int.Parse(Console.ReadLine());
//    Console.Write("Enter second number :: "); 
//num2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Sum = " + (num1 + num2)); 
//Console.ReadKey(); 
 

//Try re-writing the code using:
//(a) long value
//(b) float or double value
//(c) char value(single character)
    internal class Program
    {
        static void Main(string[] args)
        {
            longSum();
            doubleSum();
            charSum();
        }
        static void longSum()
        {
            long num1, num2;
            Console.Write("Enter first long number :: ");
            num1 = long.Parse(Console.ReadLine());
            
            Console.Write("Enter second long number :: ");
            num2 = long.Parse(Console.ReadLine());

            Console.WriteLine("Sum = " + (num1 + num2));

        }
        static void doubleSum()
        {
            double num1, num2;
            Console.Write("Enter first double :: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second double :: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum = " + (num1 + num2));
        }
        
        static void charSum()
        {
            char num1, num2;
            Console.Write("Enter the first char :: ");
            num1 = char.Parse(Console.ReadLine());

            Console.Write("Enter the second char :: ");
            num2 = char.Parse(Console.ReadLine());

            Console.WriteLine($"Sum = {(char)(num1 + num2)} with a numeric value of {num1 + num2}");
        }
    }
}
