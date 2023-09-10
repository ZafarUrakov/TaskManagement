// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

using TaskManagement.Brokers;
using TaskManagement.Managers;

namespace TaskManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var report = new Report();
            var taskManager = new TaskManager();
            Console.WriteLine("Welcome to Task Manager!");

            while (true)
            {
                int menuSelection = report.ShowMenu();

                switch (menuSelection)
                {
                    case 1:
                        taskManager.ViewTasks(); break;
                    case 2:
                        taskManager.AddTask(); break;
                    case 3:
                        taskManager.UpdateTask(); break;
                    case 4:
                        taskManager.DeleteTask(); break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please select a valid option.");
                        break;
                }

            }
        }
    }
}

