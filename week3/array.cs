//array concept example 
using System;
using System.Collections.Generic;


class Program
{
    public static void Main()

    {
        Console.WriteLine("Please enter the no of elements in array  :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Please enter the elements of array  :");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Array elements are:");
        foreach (int item in arr)
        {
            Console.WriteLine(item + " ");
        }


        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("The sum of all the no in array are : " + sum);


        double avg = 0;
        avg = sum / n;

        Console.WriteLine("The avg of the given array is : " + avg);


        // for printing even and odd number iis array 

        Console.WriteLine("The even no in the list are : ");
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
                Console.Write(arr[i] + " ");
        }
        
                Console.WriteLine("/nThe odd no in the list are : ");
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 != 0)
                Console.Write(arr[i] + " ");
        }


        
    }
}