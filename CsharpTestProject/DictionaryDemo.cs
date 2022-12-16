using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {
            //Creating Dictionary
            Dictionary<String, Int16> AuthorList = new Dictionary<string, short>();
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Stephanie Mayor", 40);
            AuthorList.Add("Chetan Bhagat", 42);
            AuthorList.Add("J.K.Rowling", 41);

            //Read Dictionary Data
            Console.WriteLine("Author List: ");
            foreach(KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine($"Key: {author.Key}, Value: {author.Value}");
            }

            //Get the count of dictionary entries
            Console.WriteLine($"Count: {AuthorList.Count}");

            //Set item value
            AuthorList["Mike Gold"] = 30;

            Console.WriteLine("After Change:");

            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine($"Key: {author.Key}, Value: {author.Value}");
            }

            Console.WriteLine("After Remove:");
            AuthorList.Remove("Mike Gold");

            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine($"Key: {author.Key}, Value: {author.Value}");
            }

            //Can clear with AuthorList.Clear();

            //Second dictionary

            Dictionary<string, int> TestDictionary = new Dictionary<string, int>();
            TestDictionary.Add("Test1", 1);
            TestDictionary.Add("Test2", 2);
            TestDictionary.Add("Test3", 3);

            foreach(KeyValuePair<string, int> test in TestDictionary)
            {
                Console.WriteLine(test.Key + " " + test.Value);
            }
            TestDictionary.Remove("Test2");
            Console.WriteLine("\nAfter Removal: ");

            foreach(KeyValuePair<string, int> test in TestDictionary)
            {
                Console.WriteLine(test.Key + " " + test.Value);
            }


            TestDictionary["Test3"] = 4;
            Console.WriteLine("\nAfter Change: ");

            foreach(KeyValuePair<string, int> test in TestDictionary)
            {
                Console.WriteLine(test.Key + " " + test.Value);
            }

            Console.ReadKey();
        }
    }
}
