// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------

using TaskManagement.Brokers;
using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    public partial class TaskManager : ITaskManager
    {
        private List<Local.Task> tasks = new List<Local.Task>();
        ValueManipulator valueManipulator = new ValueManipulator();

        public void ViewTasks()
        {
            Console.Clear();
            Console.WriteLine("Tasks:");
            foreach(var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, " +
                    $"DueData: {task.DueDate}, Completed: {task.IsCompleted}");
            }
        }
    }
}
