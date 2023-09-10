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

        public int GetUserValueByMassageForId(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine()!);
        }
    }
}
