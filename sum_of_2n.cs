using System;

class Program{
  static void Main()
  {

    Console.WriteLine("Please enter the numer 1 : ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the numer 2 : ");
    int n2 =  Convert.ToInt32(Console.ReadLine());

    int sum=n1+n2;

    Console.WriteLine("The sum of 2 numbers = "+sum);
  }
}