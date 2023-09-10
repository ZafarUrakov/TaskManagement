// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

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
        public void AddTask()
        {
            Local.Task task = new Local.Task();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            task.Id = valueManipulator.GetUserValueByMassageForId("Enter task id: ");
            task.Title = valueManipulator.GetUserValueByMassage("Enter task title: ");
            task.Description = valueManipulator.GetUserValueByMassage("Enter task description: ");
            Console.Write("Enter due date (yyyy-mm-dd): ");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime dueDate)) // attempting to convert a string a date format
            {
                task.DueDate = dueDate;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid date format. Task not added.");
                Console.ResetColor();
            }

            tasks.Add(task);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task added successfully.");
            Console.ResetColor();
        }
    }
}
