using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public class MonthOfYear : IEnumerable
    {
        private readonly string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < months.Length; index++)
            {
                //Yield each month of the year;
                yield return months[index];
            }
        }
    }

    public class Pets : IEnumerable
    {
        private readonly string[] pets = { "Bird", "Cat", "Dog", "Fish", "Hamster", "Lizard" };
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < pets.Length; i++)
            {
                yield return pets[i];
            }
        }
    }

    internal class IteratorDemo
    {
        static void Main(string[] args)
        {
            MonthOfYear months = new MonthOfYear();
            foreach(string month in months)
            {
                Console.WriteLine($"Month: {month}");
            }

            Pets pets = new Pets();
            foreach(string pet in pets)
            {
                Console.WriteLine($"Pet: {pet}");
            }
        }
    }
}
