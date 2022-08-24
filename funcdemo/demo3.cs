using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdemo
{
    internal class demo3
    {
        public static int minof(int num1, int num2, out int num)
        {
            if (num1 < num2)
                return num = num1;
            else
                return num = num2;
        }
        public static void Main()
        {

            int num1, num2;

            Console.Write("Input the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
             minof(num1, num2, out int num);
            Console.WriteLine($"the smallest numbers is {num}");
        }
    }
}
