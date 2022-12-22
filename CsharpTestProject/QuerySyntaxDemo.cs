using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    internal class QuerySyntaxDemo
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 4, 1, 3, 9, 8, 7, 6, 2, 0 };

            var filterResult = from num in numbers
                               where num < 3 || num > 7
                               select num;

            Console.WriteLine("Filter query result:");

            foreach(var result in filterResult)
            {
                Console.Write(result + " ");
            }

            Console.WriteLine();

            //Order by result
            Console.WriteLine("Order Result:");

            var orderResult = from num in numbers
                              where num < 3 || num > 7
                              orderby num ascending
                              select num;

            foreach(var result in orderResult)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            //Group by

            string[] groupingQuery = { "cabbage", "broccoli", "beans", "barley", "carrot" };

            IEnumerable<IGrouping<char, string>> foodGroups = from items in groupingQuery
                                                              group items by items[0];
            Console.WriteLine("Grouping query result:");
            foreach(var gResult in foodGroups)
            {
                foreach(var item in gResult)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            // Queries with method syntax
            // Using lambda

            var largeNumbers = numbers.Where(c => c > 5).ToList();
            largeNumbers.ForEach(c => Console.Write(c + " "));
        }
    }
}
