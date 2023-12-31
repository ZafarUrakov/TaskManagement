﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    public partial class TaskManager
    {
        public void AddTask()
        {
            Local.Task task = new Local.Task();
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
            task.Id = valueManipulator.GetUserValueByMassageForNumber("Enter task id: ");
            task.Title = valueManipulator.GetUserValueByMassage("Enter task title: ");
            task.Description = valueManipulator.GetUserValueByMassage("Enter task description: ");
            Console.Write("Enter due date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate)) // attempting to convert a string a date format
            {
                task.DueDate = dueDate;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid date format. Task not added.");
                Console.ResetColor();
            }

            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }
    }
}
