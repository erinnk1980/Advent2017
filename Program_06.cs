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
            int[] x = new int[] { 11, 11, 13, 7, 0, 15, 5, 5, 4, 4, 1, 1, 7, 1, 15, 11 };
            int count = 0;
            while (!seen.ContainsKey(toString(x)))
            {
                seen.Add(toString(x), count);
                x = redist(x);
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        static int[] redist(int[] x)
        {
            int max = x[0];
            int idx = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                    idx = i;
                }
            }
            int rem = x[idx];
            x[idx] = 0;
            while (rem > 0)
            {
                idx = (idx + 1) % x.Length;
                x[idx]++;
                rem--;
            }
            return x;
        }

        static Dictionary<string, int> seen = new Dictionary<string, int>();

        static string toString(int[] x)
        {
            string s = x[0].ToString();
            for (int i = 1; i < x.Length; i++)
            {
                s += "," + x[i].ToString();
            }
            return s;
        }
        // Part 2
        static void Main(string[] args)
        {
            int[] x = new int[]{ 11, 11, 13, 7, 0, 15, 5, 5, 4, 4, 1, 1, 7, 1, 15, 11 };
            int count = 0;
            while (!seen.ContainsKey(toString(x)))
            {
                seen.Add(toString(x), count);
                x = redist(x);
                count++;
            }
            Console.WriteLine(count - seen[toString(x)]);
            Console.ReadLine();
        }
    }
}
