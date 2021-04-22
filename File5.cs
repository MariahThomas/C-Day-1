using System.IO;
using System;

class Program
{
    static void Main()
    {
      float Number;
      Console.WriteLine("Enter Your Age :");
      Number = Convert.ToInt32(Console.ReadLine());
      if (Number < 18) 
      {
          Console.WriteLine("\nYou are not eligible to vote");
      }
      else if (Number >= 60)
      {
          Console.WriteLine("\nYou are a senior citizen");
      }
      else 
      {
          Console.WriteLine ("\nYou are eligible to vote");
      }
         
    }
}