using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your name (or type 'exit' to quit): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You must enter a valid input.");
                    continue;
                }
                else if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine($"Hello, {input}!");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
