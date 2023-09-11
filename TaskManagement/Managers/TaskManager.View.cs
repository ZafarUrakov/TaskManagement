// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    public partial class TaskManager
    {
        public void ViewTasks()
        {
            if (tasks.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.WriteLine("Tasks:");
                for (int loopManager = 0; loopManager < tasks.Count; loopManager++)
                {
                    Local.Task task = tasks[loopManager];
                    Console.WriteLine($"{loopManager}. ID: {task.Id}, Title: {task.Title}, " +
                        $"DueData: {task.DueDate}, Completed: {task.IsCompleted}");
                }
                int numberOfTask = valueManipulator.
                    GetUserValueByMassageForNumber("Enter the task number to open it: ");

                Local.Task taskDescription = tasks[numberOfTask];
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.WriteLine($"-Task description-");
                Console.WriteLine(taskDescription.Description);
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, but you have not added tasks yet. Add at least one!");
                Console.ResetColor();
            }
        }
    }
}
