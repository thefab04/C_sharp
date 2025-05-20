using System;

class Program
{
  static void Main(String[] args)
  {
    Console.WriteLine("Enter the number n : ");
    int n = Convert.ToInt32(Console.ReadLine());

    int fact=1;
    for (int i = 1; i < n; i++)
    {
      fact *= i;
      Console.WriteLine("The factorial of {0} is {1}", i, fact);
    }
  }
}