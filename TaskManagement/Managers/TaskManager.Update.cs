// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

namespace TaskManagement.Managers
{
    public partial class TaskManager
    {
        public void UpdateTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter the Id of the task to update: ");
            if (int.TryParse(Console.ReadLine()!, out int id))
            {
                var taskToUpdate = tasks.FirstOrDefault(t => t.Id == id);
                if (taskToUpdate != null)
                {
                    Action<bool> updateTaskCompletion = isCompleted => taskToUpdate.IsCompleted = isCompleted;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Is the task completed? (true/false): ");
                    if (bool.TryParse(Console.ReadLine(), out bool isComleted))
                    {
                        updateTaskCompletion(isComleted);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Task updated successfully.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Task not updated.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
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
    }
}
