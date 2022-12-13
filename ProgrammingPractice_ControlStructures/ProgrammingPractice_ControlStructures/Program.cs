using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingPractice_ControlStructures
{
    internal class Program
    {
        static char option;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1: Print tables of all numbers between starting and ending number with defined multiples.");
                Console.WriteLine("2: Calculate sum of first n integers");
                Console.WriteLine("3: Print factorial of a number.");
                Console.WriteLine("4: print first n numbers of the fibonacci series.");
                Console.WriteLine("5: Check whether a number is prime or not.");
                Console.WriteLine("6: Exit.");
                option = Console.ReadLine()[0];
                switch(option)
                {
                    case '1':
                        tables();
                        break;
                    case '2':
                        sum();
                        break;
                    case '3':
                        factorial();
                        break;
                    case '4':
                        fibonacci();
                        break;
                    case '5':
                        primeCheck();
                        break;
                    case '6':
                        break;
                    default:
                        break;
                }
            } while (!option.Equals('6'));
        }
        static void tables()
        {
            int start, end, n, count;
            Console.Write("Enter a start number: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter an end number: ");
            end = int.Parse(Console.ReadLine());

            Console.Write("Enter the multiple value: ");
            n = int.Parse(Console.ReadLine());

            count = 0;

            for(int i = start; i <= end; i++)
            {
                if(i % n == 0)
                {
                    Console.Write(i+ " ");
                    count++;
                }
                if(count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void sum()
        {
            int n;
            int sum = 0;
            Console.Write("Enter a stopping number: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void factorial()
        {
            int ans = 1;
            Console.Write("Enter the number to get the factorial of: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 1; i--)
            {
                ans *= i;
            }
            Console.WriteLine(ans);
        }
        static void fibonacci()
        {
            Console.Write("Enter the number of sequences: ");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];

            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    sequence[i] = 0;
                    Console.Write("0, ");
                }
                else if(i == 1)
                {
                    sequence[i] = 1;
                    Console.Write("1, ");
                }
                else
                {
                    sequence[i] = sequence[i-1] + sequence[i - 2];
                    if(i == n - 1)
                    {
                        Console.WriteLine($"{sequence[i]}");
                    }
                    else
                    {
                        Console.Write($"{sequence[i]}, ");
                    }
                }
            }
        }
        static void primeCheck()
        {
            int n;
            Console.WriteLine("Enter a number to check: ");
            n = int.Parse(Console.ReadLine());
            bool prime = true;

            if (n == 2)
            {
                prime = true;
            }else if(n % 2 == 0)
            {
                prime = false;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            Console.WriteLine((prime) ? "Prime" : "Not Prime");
        }

    }
}
