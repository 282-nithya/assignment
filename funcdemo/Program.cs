using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstNumber = (n / 1000) % 10;
        int secondNumber = (n / 100) % 10;
        int thirdNumber = (n / 10) % 10;
        int fourthNumber = (n % 10);

        Console.WriteLine("The sum of the digits is: {0}", firstNumber + secondNumber + thirdNumber + fourthNumber);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
        Console.WriteLine("Last digit upfront: {0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
    }
}
