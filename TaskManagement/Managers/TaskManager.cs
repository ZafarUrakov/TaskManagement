// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------

using TaskManagement.Brokers;
using TaskManagement.Managers.Interfaces;
using Local = TaskManagement.Models;

namespace TaskManagement.Managers
{
    public partial class TaskManager : ITaskManager
    {
        private List<Local.Task> tasks = new List<Local.Task>();
        ValueManipulator valueManipulator = new ValueManipulator();
    }
}
