// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

namespace TaskManagement.Brokers
{
    internal class Report
    {
        public int ShowMenu()
        {
            Console.WriteLine("1. View tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Update a task");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine()!, out choice))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Please enter your choice: ");
                Console.ResetColor();
            }
            return choice;
        }

        public void Default()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please select a valid option.");
        }

        public void Quit()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
