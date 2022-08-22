using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class solution3
    {
        static int CountVowels(string str)
        {
            int i = 0;
            int countVowels = 0;

            for (i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') ||
                    (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U'))
                    countVowels++;
            }
            return countVowels;
        }

        public static void Main()
        {
            int vowels = 0;
            string str = "";

            Console.Write("Enter the string: ");
            str = Console.ReadLine();

            vowels = CountVowels(str);
            Console.WriteLine("Total vowels are: " + vowels);
        }
    }
}

