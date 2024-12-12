using System;
using System.Collections.Generic;

class Task
{
    public string Description { get; set; }

    public Task(string description)
    {
        Description = description;
    }
}

class Program
{
    static List<Task> toDoList = new List<Task>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter the task description: ");
        string description = Console.ReadLine();
        toDoList.Add(new Task(description));
        Console.WriteLine("Task added successfully.");
    }

    static void ViewTasks()
    {
        Console.WriteLine("To-Do List:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i].Description}");
        }
    }

    static void RemoveTask()
    {
        Console.Write("Enter the number of the task to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
        {
            toDoList.RemoveAt(index - 1);
            Console.WriteLine("Task removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
