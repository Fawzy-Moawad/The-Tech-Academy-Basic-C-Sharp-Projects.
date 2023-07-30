using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight: ");
            double weight = double.Parse(Console.ReadLine());

            // Check if the package weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // End the program
            }

            // Prompt the user for package dimensions
            Console.Write("Please enter the package width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = double.Parse(Console.ReadLine());

            // Check if the dimensions total greater than 50
            double dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return; // End the program
            }

            // Calculate the quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}