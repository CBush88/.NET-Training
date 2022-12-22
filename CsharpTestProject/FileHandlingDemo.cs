using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpTestProject
{
    internal class FileHandlingDemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int i = 1; i <= 20; i++)
            {
                fs.WriteByte((byte)i);
            }

            fs.Position= 0;

            for(int i = 0; i < 20; i++)
            {
                Console.Write(fs.ReadByte() + " ");
            }

            fs.Close();
            Console.ReadKey();
        }
    }
}
