// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

namespace TaskManagement.Managers
{
    public partial class TaskManager
    {
        public void DeleteTask()
        {
            if (tasks.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.Write("Enter the Id of the task to delete: ");
                if (int.TryParse(Console.ReadLine()!, out int id))
                {
                    var taskToDelete = tasks.FirstOrDefault(x => x.Id == id);
                    if (taskToDelete != null)
                    {
                        tasks.RemoveTask(taskToDelete);
                        Console.WriteLine("Task deleted successfully.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Task not found.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid task Id.");
                    Console.ResetColor();
                }
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
