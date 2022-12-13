using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array - collection of homogeneous data
            // Operations Traversing, Searching, Sorting, Inserting, Deleting, etc.
            // 1 dimensional

            // brackets must be with type

            //float[] marks = new float[5];
            //float sum = 0.0F, percentage;
            //int[] ages = { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write($"Enter marks for Subject {i + 1} :: ");
            //    marks[i] = float.Parse(Console.ReadLine());
            //}
            //// Traversing
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i]);
            //    sum += marks[i];
            //}
            //percentage = sum / (marks.Length * 50) * 100;
            //Console.WriteLine($"Sum of Marks = {sum} and Percentage = {percentage}");

            //Array.Sort(marks);
            //Array.Reverse(marks);
            //Array.ForEach(marks, mark => Console.WriteLine(mark));

            //Console.ReadKey();

            //Two - Dimensional Arrays or tables or matrix

            //int[,] matrix = new int[3, 3];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{i}, {j} :: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //Three - Dimensional Array int[,,] matrix = new int[3, 3, 3]

            // Jagged Arrays(Variable Size Arrays) -Arrays that can have different number of columns in each row
            // 23   32
            // 56   12  13  14
            // 78

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[4];
            //jaggedArray[2] = new int[1];

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{i}, {j} :: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            // Dynamic number of Rows and Columns in each row


            // 3d arrays -> cube, cuboid, etc.
            // 4d, 5d, 6d, etc

            // Write code to design a patern of numbers as follows:
            //     5
            //    45
            //   345
            //  2345
            // 12345
            // n to be decided by user

            //bool again = true;
            //while(again){
            //    Console.WriteLine("Enter a number");
            //    int input = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < input; i++)
            //    {
            //        for (int j = i; j < input - 1; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = i; j >= 0; j--)
            //        {
            //            Console.Write(input - j);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Would you like to enter another number?");
            //    char continueInput = char.ToLower(Console.ReadLine()[0]); 
            //    if(!(continueInput.Equals('y')){
            //        again = false;
            //    }
            //}


            // foreach with 2d array
            //string[,] namecodes = new string[3, 3] { {"A", "B", "C"}, { "a", "b", "c" }, {"x", "y", "z" } };
            //foreach(string code in namecodes)
            //{
            //    Console.WriteLine(code);
            //}
            //Console.ReadKey();

            // foreach with jagged arrays

            //Operations: Traversing, Searching, Sorting, Inserting, Deleting
            //Which of the mentioned operations cannot be completed using foreach loop?
            //Sorting, Inserting, Deleting
            //advantage, won't accidentally change and easily readable

            //string[][] namecodes = new string[3][] {
            //    new string[] { "A", "B" },
            //    new string[] { "a", "b", "c", "d" },
            //    new string[] { "x", "y", "z" }
            //};

            //foreach(string[] line in namecodes)
            //{
            //    foreach(string code in line)
            //    {
            //        Console.WriteLine(code);
            //    }
            //}
            //Console.ReadKey();

            //Console.WriteLine("Enter a starting point");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an ending point");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number of prime numbers");
            //int num = int.Parse(Console.ReadLine());

            //int[] primes = new int[num];
            //int index = 0;

            //for(int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
                
            //    if(index == num)
            //    {
            //        break;
            //    }
            //    if(i == 2)
            //    {
            //        primes.Append(i);
            //        index++;
            //    }
            //    for(int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            isPrime = false;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        primes[index] = i;
            //        index++;
            //    }
            //}
            //foreach(int i in primes)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


        }
    }
}
