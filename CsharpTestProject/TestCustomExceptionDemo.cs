using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    //Custom exception class
    public class TempIsZeroException: Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
    //Class to throw the exception
    public class Temperature
    {
        int temp = 0;
        public void showTemp()
        {
            if(temp == 0)
            {
                throw new TempIsZeroException("Temperature should not be zero");
            }
            else
            {
                Console.WriteLine("Temperature: " + temp);
            }
        }
    }
    public class UnderAgeException: Exception
    {
        public UnderAgeException(string message) : base(message)
        {

        }
    }
    public class Age
    {
        public int age = 17;

        public void ShowAge()
        {
            if(age >= 18)
            {
                Console.WriteLine("Age is: " + age);
            }
            else
            {
                throw new UnderAgeException("Age must be at least 18.");
            }
        }
    }
    internal class TestCustomExceptionDemo
    {
        static void Main(string[] args)
        {
            Temperature tmp = new Temperature();
            try
            {
                tmp.showTemp();
            }
            catch (TempIsZeroException te)
            {
                Console.WriteLine(te.Message);
            }

            Age age = new Age();
            try
            {
                age.ShowAge();
            }
            catch(UnderAgeException ux)
            {
                Console.WriteLine(ux.Message);
            }
            Age age2 = new Age();
            age2.age = 18;
            try
            {
                age2.ShowAge();
            }
            catch(UnderAgeException ux)
            {
                Console.WriteLine(ux.Message);
            }
        }
    }
}
