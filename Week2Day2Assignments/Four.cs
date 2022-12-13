using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Assignments
{
    //Write a program to create a structure using struct to store and display data of different types.
    struct Fruit
    {
        public int id;
        public string name;
        public string description;

        public override string ToString()
        {
            return "Id: " + id + "\nName: " + name + "\nDescription: " + description;
        }
    }    
    internal class Four
    {
        static void Main(string[] args)
        {
            Fruit f = new Fruit();
            f.id = 101;
            f.name = "Banana";
            f.description = "A yellow fruit with a peel";

            Console.WriteLine(f);
        }
    }
}
