using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a character");
            char input = Console.ReadLine().ToCharArray()[0];

            byte inputByte = (byte)input;

            if (inputByte >= 65 && inputByte <= 90)
            {
                Console.WriteLine("Uppercase");
            }
            else if (inputByte >= 97 && inputByte <= 122)
            {
                Console.WriteLine("Lowercase");
            }
            else if (inputByte >= 48 && inputByte <= 57)
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}
