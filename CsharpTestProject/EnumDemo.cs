using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class EnumDemo
    { 
        public enum Colors
        {
            Red, Green, Yellow, Blue
        }
        static void Main(string[] args)
        {
            //DayOfWeek day = DayOfWeek.Sunday; // Built-in Enum
            Colors c = Colors.Red;
            if (c == Colors.Red)
            {
                Console.WriteLine("This means stop");
            }else
            {
                Console.WriteLine("Or you can go");
            }
            Console.ReadKey();

            EnumPractice.Directions direction = EnumPractice.Directions.SouthEast;
            if(direction == EnumPractice.Directions.SouthEast)
            {
                Console.WriteLine("You are facing South-East");
            }
            else
            {
                Console.WriteLine("You are facing the wrong direction");
            }
        }
    }
    class EnumPractice
    {
        public enum Directions
        {
            North, South, East, West, NorthWest, NorthEast, SouthWest, SouthEast
        }
    }
}
