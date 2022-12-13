using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter");
            char input = Console.ReadLine()[0];

            switch (char.ToUpper(input))
            {
                case ('A'):
                case ('E'):
                case ('I'):
                case ('O'):
                case ('U'):
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}
