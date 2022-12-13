using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice_ArraysAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bigNSmallArr = new int[] { 34, 36, 67, 54, 89, 23, 21 };
            int[] bigNSmallAns = bigNSmall(bigNSmallArr);
            Console.WriteLine($"Max: {bigNSmallAns[0]}\t Min: {bigNSmallAns[1]}");

            string[] ToTitleArr = new string[] { "sunny", "hot", "rainy day", "snoWY night" };
            string[] ToTitleAns = ToTitleCase(ToTitleArr);
            foreach(string s in ToTitleAns) Console.WriteLine(s);
        }
        static int[] bigNSmall(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach(int i in arr)
            {
                if(i > max)
                {
                    max = i;
                }
                if(i < min)
                {
                    min = i;
                }
            }
            return new int[] {max, min};
        }

        static string[] ToTitleCase(string[] arr)
        {
            string[] ans = new string[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(" "))
                {
                    string[] multipleWords = arr[i].Split(' ');
                    string t ="";
                    for(int j = 0; j < multipleWords.Length; j++)
                    {
                        if(j > 0)
                        {
                            t += " ";
                        }
                        t += multipleWords[j].ToUpper().Substring(0, 1);
                        t += multipleWords[j].ToLower().Substring(1, multipleWords[j].Length - 1);
                        ans[i] = t;
                    }
                }
                else
                {
                string s = arr[i].ToUpper().Substring(0, 1);
                s += arr[i].ToLower().Substring(1, arr[i].Length - 1);
                ans[i] = s;
                }
            }
            return ans;
        }
    }
}
