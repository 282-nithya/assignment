using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdemo
{
    internal class Project
    {
        public static void swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        public static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine($"before swap a={a} b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"after a={a} b={b}");
        }
    }
}
