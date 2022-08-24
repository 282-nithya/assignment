using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdemo
{
    internal class demo1
    {
        public static void APLusB(ref int a, int b)
        { a += b; }
        public static void Main()
        {
            int a = 10;
            int b = 10;

            APLusB(ref a, b);
            Console.WriteLine($"a={a}, b={b}");


        }
    }
}
