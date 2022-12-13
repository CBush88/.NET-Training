using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_DotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value for pattern");
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
