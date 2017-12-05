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
            string[] input = File.ReadAllLines(@"G:\testinput5.txt");
            int[] x = new int[input.Length];
            for (int i = 0; i < input.Length; i++) x[i] = int.Parse(input[i]);
            int pos = 0;
            int count = 0;
            while (pos < x.Length)
            {
                int off = x[pos];
                x[pos]++;
                pos += off;
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        // Part 2
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"G:\testinput5.txt");
            int[] x = new int[input.Length];
            for (int i = 0; i < input.Length; i++) x[i] = int.Parse(input[i]);
            int pos = 0;
            int count = 0;
            while (pos < x.Length)
            {
                int off = x[pos];
                if (off >= 3) x[pos]--; else x[pos]++;
                pos += off;
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
