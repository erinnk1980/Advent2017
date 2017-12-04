using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        // Part 1
        static void Main1(string[] args)
        {
            string[] input = File.ReadAllLines(@"G:\testinput4.txt");
            int count = 0;
            foreach (string s in input)
            {
                bool good = true;
                string[] t = s.Split(' ');
                for (int i = 0; i < t.Length; i++) for (int j = i + 1; j < t.Length; j++) if (t[i] == t[j]) good = false;
                if (good) count++;
            }
            
            Console.WriteLine();
            Console.ReadLine();
        }

        static string sort(string s)
        {
            char[] c = s.ToCharArray();
            Array.Sort(c);
            return new string(c);
        }

        // Part 2
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"G:\testinput4.txt");
            int count = 0;
            foreach (string s in input)
            {
                bool good = true;
                string[] t = s.Split(' ');
                for (int i = 0; i < t.Length; i++) t[i] = sort(t[i]);
                for (int i = 0; i < t.Length; i++) for (int j = i + 1; j < t.Length; j++) if (t[i] == t[j]) good = false;
                if (good) count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
