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
            string[] input = File.ReadAllLines(@"G:\testinput_02.txt");
            int sum = 0;
            foreach (string line in input)
            {
                int min = 999999;
                int max = 0;
                string[] s = line.Split(' ');
                foreach (string t in s)
                {
                    int v = int.Parse(t);
                    min = Math.Min(min, v);
                    max = Math.Max(max, v);
                }
                sum += (max - min);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
        // Part 2
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"G:\testinput_02.txt");
            int sum = 0;            
            foreach (string line in input)
            {
                int min = 999999;
                int max = 0;
                string[] s = line.Split(' ');
                int[] x = new int[s.Length];
                for (int i = 0; i < s.Length; i++) x[i] = int.Parse(s[i]);
                for (int i = 0; i < x.Length; i++) for (int j = 0; j < x.Length; j++) if ((i != j) && ((x[i] % x[j]) == 0)) sum += x[i] / x[j];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
