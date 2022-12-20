using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n); //Declaring delegate
delegate string PunctuationAdder(string s);
namespace CsharpTestProject
{
    internal class SingleCastDelegateDemo
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum() 
        {
            return num;
        }

        public static string test = "This is a test string";

        public static string SinglePeriod(string s)
        {
            test += ".";
            return test;
        }
        public static string DoublePeriod(string s)
        {
            test += "..";
            return test;
        }

        public static string GetTestString()
        {
            return test;
        }

        static void Main(string[] args)
        {
            //Create delegate instance
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            Console.WriteLine("Original value: " + getNum());
            nc1(5);
            Console.WriteLine("Number after Addition: " + getNum());
            nc2(5);
            Console.WriteLine("Number after Multiplication: " + getNum());

            PunctuationAdder pa1 = new PunctuationAdder(SinglePeriod);
            PunctuationAdder pa2 = new PunctuationAdder(DoublePeriod);

            Console.WriteLine(GetTestString());
            pa1(test);
            Console.WriteLine("After adding a single period: " + test);
            pa2(test);
            Console.WriteLine("After adding a double period: " + test);

        }
    }
}
