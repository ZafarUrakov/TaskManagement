// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

namespace TaskManagement.Models
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
