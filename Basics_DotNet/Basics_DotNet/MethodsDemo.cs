using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Basics_DotNet
{
    class Animal
    {
        // Static member
        static int numberOfObjects = 0;
        public Animal()
        {
            numberOfObjects++;
        }
        // Static method
        public static int getObjectCount()
        {
            return numberOfObjects;
        }
    }

    internal class MethodsDemo
    {
        // Methods are like functions (block of code) that can be referenced by either a class (static) or an object(non-static or instance)
        // Calling static from static from non-static: Direct (same class) or recommened: class reference (different class)
        // Calling non-static from static: Using object reference
        // Calling static from static : Direct if same class, using class reference otherwise
        // Calling non-static from non-static: Direct (same class) or object reference (different class)
        static void Main(string[] args)
        {
            printArray(1, 2, 3, 4, 5, 6, 7);

            new Animal();
            new Animal();
            Console.WriteLine(Animal.getObjectCount());

            MethodsDemo methodsDemo= new MethodsDemo();
            methodsDemo.Show();
            methodsDemo.login("C#");
            Console.WriteLine(currentTime());

        }
        // No return value and no arguments
        void Show()
        {
            Console.WriteLine("Showing...");
        }

        // No return value but with arguments

        void login(string user)
        {
            Console.WriteLine("Logging in " + user);
            Show();
            Console.WriteLine(MethodsDemo.currentTime());
        }

        // Return value but no arguments
        static string currentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
        
        // Return value as well as arguments
        int sum(int a, int b)
        {
            return a + b;
        }

        // Method overloading
        // Number of arguments are different or type of arguments are different for a same name method (ignore the return type)
        // - Possible with or without inheritance

        int sum(int a, int b, int c)
        {
            return a + b + c;
        }

        double sum(double a, double b, double c)
        {
            return a + b + c;
        }

        // Varargs - Variable Length Arguments (Parametric Array)
        static void printArray(params int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        // Can we have a function that returns multiple values? no
        // Can we have a function that has multiple return types? no
    }
}
