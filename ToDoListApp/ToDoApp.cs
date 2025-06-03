using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.ExceptionServices;

class ToDoListApp
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n====To do list menu====");
            Console.WriteLine("1.Add task");
            Console.WriteLine("2.View Task");
            Console.WriteLine("3.Remove task ");
            Console.WriteLine("4.Exit");

            Console.WriteLine("Choose an optionn : ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter task :");
                    String task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Task added!!!!!!!!");
                    break;

                case "2":
                    Console.WriteLine("\n-----your tasks");
                    if (tasks.Count == 0)
                        Console.WriteLine("No tasks");
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}.{tasks[i]}");

                    }
                    break;

                case "3":
                    Console.WriteLine("enter the task number to remove : ");
                    int index;
                    if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= tasks.Count)
                    {
                        tasks.RemoveAt(index - 1);
                        Console.WriteLine("task removed");
                    }
                    else
                        Console.WriteLine("Invalid task number");
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting the list");
                    break;

                default:
                    Console.WriteLine("Invalid Choice , Try again !");
                    break;


            }


        }
    }
}