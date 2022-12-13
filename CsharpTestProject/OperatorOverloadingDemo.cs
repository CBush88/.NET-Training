using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public class Complex
    {
        public int real;
        public int imaginary;

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex (c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary- c2.imaginary);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }

    }

    internal class OperatorOverloadingDemo
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(5, 7);
            Complex num2 = new Complex(4, 6);

            Complex sum = num1 + num2;
            Complex diff = num1 - num2;

            Console.WriteLine($"First Complex Number: {num1}");
            Console.WriteLine($"Second Complex Number: {num2}");
            Console.WriteLine($"Addition of two complex numbers: {sum}");
            Console.WriteLine($"Subtraction of two complex numbers: {diff}");
        }
    }
}
