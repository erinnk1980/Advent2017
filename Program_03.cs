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
            int x = 0; int y = 0;
            int i = 1;
            int val = 1;
            int target = 312051;

            while (val < target)
            {
                for (int j = 0; j < i; j++)
                {
                    x++;
                    val++;
                    if (val == target) break;
                }
                if (val == target) break;
                for (int j = 0; j < i; j++)
                {
                    y++;
                    val++;
                    if (val == target) break;
                }
                if (val == target) break;
                i++;
                for (int j = 0; j < i; j++)
                {
                    x--;
                    val++;
                    if (val == target) break;
                }
                if (val == target) break;
                for (int j = 0; j < i; j++)
                {
                    y--;
                    val++;
                    if (val == target) break;
                }
                if (val == target) break;
                i++;
            }
            Console.WriteLine(Math.Abs(x) + Math.Abs(y));
            Console.ReadLine();
        }

        static Dictionary<int, int> spiral = new Dictionary<int, int>();
        static void put(int x, int y, int value) { spiral[y * 10000 + x] = value;  }
        static int get(int x, int y) { return spiral.ContainsKey(y * 10000 + x) ? spiral[y * 10000 + x] : 0; }

        // Part 2
        static void Main(string[] args)
        {
            // One can lookup the sequence in OEIS: https://oeis.org/A141481
            // But actual programming code follows.
            int x = 0; int y = 0;
            int i = 1;
            int val = 1;
            put(x, y, val);
            int target = 312051;
            while (val < target)
            {
                for (int j = 0; j < i; j++)
                {
                    x++;
                    val = get(x - 1, y) + get(x + 1, y) + get(x, y - 1) + get(x, y + 1) + get(x - 1, y - 1) + get(x - 1, y + 1) + get(x + 1, y - 1) + get(x + 1, y + 1);
                    put(x, y, val);
                    if (val > target) break;
                }
                if (val > target) break;
                for (int j = 0; j < i; j++)
                {
                    y++;
                    val = get(x - 1, y) + get(x + 1, y) + get(x, y - 1) + get(x, y + 1) + get(x - 1, y - 1) + get(x - 1, y + 1) + get(x + 1, y - 1) + get(x + 1, y + 1);
                    put(x, y, val);
                    if (val > target) break;
                }
                if (val > target) break;
                i++;
                for (int j = 0; j < i; j++)
                {
                    x--;
                    val = get(x - 1, y) + get(x + 1, y) + get(x, y - 1) + get(x, y + 1) + get(x - 1, y - 1) + get(x - 1, y + 1) + get(x + 1, y - 1) + get(x + 1, y + 1);
                    put(x, y, val);
                    if (val > target) break;
                }
                if (val > target) break;
                for (int j = 0; j < i; j++)
                {
                    y--;
                    val = get(x - 1, y) + get(x + 1, y) + get(x, y - 1) + get(x, y + 1) + get(x - 1, y - 1) + get(x - 1, y + 1) + get(x + 1, y - 1) + get(x + 1, y + 1);
                    put(x, y, val);
                    if (val > target) break;
                }
                if (val > target) break;
                i++;
            }
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}
