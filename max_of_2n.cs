using System;

class Program{
  static void Main()
  {

    Console.WriteLine("Please enter the number 1 : ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the number 2 : ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    if(n1>n2){
        Console.WriteLine( "is greater" +n1);
      }

      else{
        Console.WriteLine( "is greater" +n2);
      }
    }

  }
