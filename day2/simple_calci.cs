using System;
class Program
{
  static int num1, num2;
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the first number :");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Second number :");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("the first number = " + num1);
    Console.WriteLine("the second number = " + num2);

    operations();
  }



  static void operations()
  {
    add();
    sub();
    mul();
    div();
  }
    static void add()
    {
      int result = num1 + num2;
      Console.WriteLine("the result of addition = " + result);
    }

    static void sub()
    {
      int result = num1 - num2;
      Console.WriteLine("the result of subtraction = " + result);
    }

    static void mul()
    {
      int result = num1 * num2;
      Console.WriteLine("the result of multiplication = " + result);
    }

    static void div()
    {
      int result = num1 / num2;
      Console.WriteLine("the result of division = " + result);
    }
  }
    