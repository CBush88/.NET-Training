using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

//Write a program that reads contents from a file and writes them in another. 

//Additionally (Not Required): 

//If any line starts with I, should be ignored 
//If any line contains "Code" should be changed to "Program" 
//Introducing Regular Expression to manage different changes….. 
//Converting every word to Titlecase before writing 

namespace ProgrammingPractice_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "file.txt";
            string filePath2 = "file2.txt";
            if (!File.Exists(filePath))
            {
                string text = "Hello\n" + "World\n" + "I am in the file.\n" + "This is code\n";

                File.WriteAllText(filePath, text);
            }

            SimpleWrite(filePath, filePath2);

            Console.WriteLine(File.ReadAllText(filePath2));

            FancyWrite(filePath, filePath2);

            Console.WriteLine(File.ReadAllText(filePath2));

            Console.ReadKey();

        }
        static void SimpleWrite(string filePath, string filePath2)
        {
            File.WriteAllText(filePath2, File.ReadAllText(filePath));
        }
        static string ToTitle(string s)
        {
            string result = s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
            return result;
        }
        static void FancyWrite(string filePath, string filePath2)
        {
            string beginsWithI = @"^I.+";
            Regex iTest = new Regex(beginsWithI);

            string containsCode = @"Code";
            Regex codeTest = new Regex(containsCode);

            string file1Text = File.ReadAllText(filePath);

            string[] lines = file1Text.Split('\n');

            List<string> outputLines = new List<string>();

            for(int i = 0; i < lines.Length; i++)
            {
                if (!iTest.IsMatch(lines[i]) && lines[i].Length > 0)
                {
                    string[] words = lines[i].Split(' ');

                    words = words.Select(w => ToTitle(w)).ToArray();
                    words = words.Select(w => codeTest.IsMatch(w) ? "Program" : w).ToArray();

                    outputLines.Add(string.Join(" ", words));
                }
            }
            string output = string.Join("\n", outputLines);
            File.WriteAllText(filePath2, output);
        }
    }
}
