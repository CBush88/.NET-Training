using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Basics_DotNet
{
    internal class PropertiesDemo
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 20;

            int l = rectangle.Length;

            Console.WriteLine(rectangle.Area);
        }

        // Properties are something (fields) that can be get (after =) and set (before =)
        // Read Only (only GET), Write Only(only Set), and Read Write properties (Get and Set)

        class Rectangle
        {
            int length;
            public int Length
            {
                get => length;
                set => length = (value < 0) ? 0 : value;
            }
            public int Width { get; set; }

            public int Area { get
                {
                    return Length * Width;
                }
            }
        }
    }
}
