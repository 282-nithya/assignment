﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class solution7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your current age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your age after 10 years:");
            age = age + 10;
            Console.WriteLine("{0} ", age);
        }
    }
}
