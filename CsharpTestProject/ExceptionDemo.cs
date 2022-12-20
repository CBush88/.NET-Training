using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            int x = 23, y = 0;
            int result = 0;
            try
            {
                result = x / y;
                Console.WriteLine("Division result is: " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Result = " + result);
                Console.ReadKey();
            }
        }
    }
}
