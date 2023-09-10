// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;
using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    public static class TaskExtensions
    {
        internal static void RemoveTask(this List<Local.Task> tasks, Local.Task task) =>
            tasks.Remove(task);
    }
}
