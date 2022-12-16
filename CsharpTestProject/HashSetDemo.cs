using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            //create one hash set
            HashSet<string> names = new HashSet<string>();
            names.Add("Chris");
            names.Add("Robert");
            names.Add("Tom");

            //read the hashset
            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }

            HashSet<string> names1 = new HashSet<string>();
            names1.Add("Erica");
            names1.Add("Janet");
            names1.Add("Elizabeth");

            //Adding to hash sets
            names.UnionWith(names1);
            Console.WriteLine("\nAfter Union of two sets");

            foreach(string name in names)
            {
                Console.WriteLine("Name: " + name);
            }


            HashSet<int> nums = new HashSet<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            Console.WriteLine("Items in nums");

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

            HashSet<int> odds = new HashSet<int>();
            odds.Add(1);
            odds.Add(3);
            odds.Add(5);
            odds.Add(7);
            Console.WriteLine("Items in odds");

            foreach(int num in odds)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nNums and Odds intersect: ");

            nums.IntersectWith(odds);

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
