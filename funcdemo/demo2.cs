using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdemo
{
    internal class demo2
    {
        public static int Mul(int num1, int num2, int num3)
        {
            int result;
            result = num1 * num2 * num3;
            return result;
        }
        public static void Main()
        {

            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = Mul(num1, num2, num3);
            Console.WriteLine($"the multiplication of 3 numbers is {result}");
        }

    }
}
