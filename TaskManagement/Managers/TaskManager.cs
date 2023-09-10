// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    internal partial class TaskManager
    {
        private List<Local.Task> tasks = new List<Local.Task>();

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
