using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_DotNet
{
    internal class Program
    {
        static void swap(ref Int32 a, ref Int32 b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main1(string[] args)
        {
            // Console.WriteLine("Hi, I'm learning C#.");
            // Console.Write("It is \n somewhat similar to Java.");
            // Console.WriteLine("My Program is saved at D:\\DotNet\\Programs");
            // Console.WriteLine("The IDE is really \"Quick\"");
            // Console.ReadKey();

            // int a = 10;
            // int b = 20;
            // Console.WriteLine($"Before Swapping: {a}, {b}");
            // swap(ref a, ref b);
            // Console.WriteLine($"After Swapping: {a}, {b}");

            //     int input; 
            //     Console.Write("Input the last 4 digits of your debit card :: ");
            //     // input = int.Parse(Console.ReadLine().Substring(0,4));
            //     input = int.Parse(Console.ReadLine());
            //     while(!(input <= 9999 && input >= 1000))
            //     {
            //         Console.WriteLine("Try Again");
            //         input = int.Parse(Console.ReadLine());
            //     }
            //     Console.WriteLine($"Is the input {input} correct?");
            //     Console.ReadKey();
            // }

            //    int value1, value2;
            //    char operation = '0';

            //    Console.Write("Number 1 :: ");
            //    value1 = int.Parse(Console.ReadLine());
            //    Console.Write("Number 2 :: ");
            //    value2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(" + for Addition");
            //    Console.WriteLine(" - for Subtraction");
            //    Console.WriteLine(" * for Multiplication");
            //    Console.WriteLine(" / for Division");
            //    Console.WriteLine(" % for Modular Division");
            //    Console.WriteLine("Please type the character for operation :: ");
            //    operation = Console.ReadLine()[0];

            //    int res = 0;

            //    switch (operation)
            //    {
            //        case '+':
            //            res = value1 + value2;
            //            break;
            //        case '-':
            //            res = value1 - value2;
            //            break;
            //        case '*':
            //            res = value1 * value2;
            //            break;
            //        case '/':
            //            res = value1 / value2;
            //            break;
            //        case '%':
            //            res = value1 % value2;
            //            break;
            //        default:
            //            Console.WriteLine("Please give correct input!");
            //            break;
            //    }
            //    Console.WriteLine("The result of the operation = {0}", res);
            //    Console.ReadKey();

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //bool c = a > b;

            //long d = a + 10L;

            //int e = a | b; // bitwise operator OR (|) converts to binary and compares bits
            //int f = a & b; // bitwise operator AND (&)

            //if (a > 10 && b < 20) ; //logical operator AND (&&)

            //if (a > b)//expression resulting in a bool value
            //{

            //}

            //// Ternary Operator (?:)
            ////(Condition)?statements, if true: statements, if false
            //string result = (a % 2 == 0) ? "Even" : "Odd";
            ////(a % 2 == 0) ? Console.WriteLine("Even") : Console.WriteLine("Odd"); // broken, no squiggly line
            //Console.WriteLine((a % 2 == 0) ? "Even" : "Odd");
            //Console.ReadKey();

            // Iterating statement or iterations or loops
            // entry controlled loops
            // for and while

            //Console.Write("Enter a number :: ");
            //int a = int.Parse(Console.ReadLine());
            //int b;

            //while(a > 0) // an expression resulting in a boolean value // condition for the loop
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}

            //for(a = 0; a < 10; a++) // initial value, condition, iterator  //can skip any section, just leave that part blank, but include all semicolons
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadKey();

            ////can use multiple variables
            //for(a = 0, b = 0; a <= 10 && b <= 10; a++, b++)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    // Only does one for some reason?
            //}

            //// pre increment and post increment, no difference in a for loop, but will 

            //for(int i = 1; i <= 10;)
            //{
            //    Console.WriteLine(i++);
            //    //1 - 10
            //}
            //for(int i = 1; i <= 10;)
            //{
            //    Console.WriteLine(++i);
            //    //2 - 11
            //}

            ////int i;
            //for (int i = 1; i <= 10; i++);
            //{
            //    Console.WriteLine(i);
            //    // error, i out of scope because of semicolon after for statement
            //    // updated with i above for, will only output 11;
            //}

            // Nesting of loops
            // Largest part of program complexity

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Console.WriteLine("Input value for pattern");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= input; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Console.WriteLine("Input value for pattern");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = input; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            // exit controlled loop
            // do while
        }
    }
}
