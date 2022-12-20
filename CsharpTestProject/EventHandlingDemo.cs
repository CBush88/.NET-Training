using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public delegate string myDelegate(string str);
    class EventHandlingDemo
    {
        event myDelegate myEvent; //declaring event type using delegate

        public EventHandlingDemo()
        {
            this.myEvent += new myDelegate(this.Greeting);
        }

        public string Greeting(string username)
        {
            return "Greetings to " + username;
        }
        static void Main(string[] args)
        {
            EventHandlingDemo evd = new EventHandlingDemo();
            string output = evd.myEvent("in event handling");
            Console.WriteLine(output);
        }
    }
}
