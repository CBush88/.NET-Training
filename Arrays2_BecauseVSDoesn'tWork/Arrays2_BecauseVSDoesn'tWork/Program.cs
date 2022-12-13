using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2_BecauseVSDoesn_tWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Rows?");
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray2 = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"How many columns in row {i + 1}? : ");
                int columns = int.Parse(Console.ReadLine());
                jaggedArray2[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"[{i}, {j}] : ");
                    jaggedArray2[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write($"{jaggedArray2[i][j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
