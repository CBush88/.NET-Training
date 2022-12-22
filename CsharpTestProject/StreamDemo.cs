using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpTestProject
{
    internal class StreamDemo
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("streamDemo.txt");
            Console.WriteLine("Enter the text that you want to write to the file");
            string str = Console.ReadLine();

            sw.WriteLine(str);
            sw.Flush();
            sw.Close();

            StreamReader sr = new StreamReader("streamDemo.txt");
            Console.WriteLine("The content of the file: ");
            
            //Where to start reading

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string rdr = sr.ReadLine();
            while(rdr != null)
            {
                Console.WriteLine(rdr);
                rdr = sr.ReadLine();
            }

            Console.ReadKey();

            BinaryWriter writer = new BinaryWriter(File.Open("TestFile.txt", FileMode.OpenOrCreate));
            Console.WriteLine("Enter the number to stop printing to file at");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i <= num; i++)
            {
                writer.Write(i);
            }
            writer.Close();

            Console.WriteLine("Result: ");

            BinaryReader reader = new BinaryReader(File.Open("TestFile.txt",FileMode.Open));
            
            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(reader.ReadInt32());
            }
            
            reader.Close();
            Console.ReadKey();

        }
    }
}
