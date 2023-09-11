// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Putting Tasks In Order 
// --------------------------------------------------------;

namespace TaskManagement.Brokers
{
    public class ValueManipulator
    {
        public string GetUserValueByMassage(string text)
        {
            Console.Write(text);
            return Console.ReadLine()!;
        }

        public int GetUserValueByMassageForNumber(string text)
        {
            Console.Write(text);
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
    }
}
