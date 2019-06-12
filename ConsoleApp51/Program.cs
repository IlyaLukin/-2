using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            string s;
            string[] split;
            Console.WriteLine("Money,money,moeny");
            Console.WriteLine("\nВведите число");
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            long.TryParse(split[0], out n);
            if (n % 2 == 1)
            {
                Console.WriteLine($"2 {n + 2}");
            }
            else
            {
                Console.WriteLine("0 0");
            }
            Console.ReadKey();
        }
    }
}
