using System.IO;
using System;

class Program
{
    static void Main()
    {
       int firstNumber, secondNumber, result;
        Console.WriteLine("Enter first number :");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number :");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        result = firstNumber + secondNumber;
        Console.WriteLine("Sum of 2 numbers is :"+result);
        Console.ReadLine();
    }
}