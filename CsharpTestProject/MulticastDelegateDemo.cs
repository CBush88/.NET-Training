using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegate int NumberChanger(int n);
//delegate string PunctuationAdder(string s);
namespace CsharpTestProject
{ 
    internal class MulticastDelegateDemo
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
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            //Calling methods
            nc = nc1;
            nc += nc2;

            //Calling multicast delegate
            nc(5);
            Console.WriteLine("Value of num: " + getNum());

            PunctuationAdder pa;
            PunctuationAdder pa1 = new PunctuationAdder(SinglePeriod);
            PunctuationAdder pa2 = new PunctuationAdder(DoublePeriod);

            //Singlecast
            Console.WriteLine(GetTestString());
            pa1(test);
            Console.WriteLine("After adding a single period: " + test);
            pa2(test);
            Console.WriteLine("After adding a double period: " + test);

            //Re-initialize
            test = "This is a test string";

            //Multicast
            pa = pa1;
            pa += pa2;
            Console.WriteLine(GetTestString());
            pa(test);
            Console.WriteLine("After delegates: " + GetTestString());

        }
    }
}
