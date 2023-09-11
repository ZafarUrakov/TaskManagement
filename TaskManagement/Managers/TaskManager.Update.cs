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
            if (tasks.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.WriteLine("Enter the Id of the task to update: ");
                if (int.TryParse(Console.ReadLine()!, out int id))
                {
                    var taskToUpdate = tasks.FirstOrDefault(t => t.Id == id); // LINQ method(FirstOrDefault)
                    if (taskToUpdate != null)
                    {
                        Action<bool> updateTaskCompletion = isCompleted => taskToUpdate.IsCompleted = isCompleted; // Delegat

                        Console.Write("Is the task completed? (true/false): ");
                        if (bool.TryParse(Console.ReadLine(), out bool isComleted))
                        {
                            Console.WriteLine("Loading...");
                            Thread.Sleep(2000);
                            updateTaskCompletion(isComleted);
                            Console.WriteLine("Task updated successfully.");
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
