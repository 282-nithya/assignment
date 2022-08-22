using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class solution2
    {
        public static void Main()
        {
            int m, n;
            Console.Write("Input a first number:");
             m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number:");
             n = Convert.ToInt32(Console.ReadLine());
            if (m < n)
            {
                Console.WriteLine($"the small num is {m}");
            }
            else
            {
                Console.WriteLine($"the small num is {n}");
            }
        }
    }

}

