using System;

class Program
{
    static void Main()
    {
        // Read input from the console
        int length = int.Parse(Console.ReadLine()); // Length in cm
        int width = int.Parse(Console.ReadLine()); // Width in cm
        int height = int.Parse(Console.ReadLine()); // Height in cm
        double percentage = double.Parse(Console.ReadLine()); // Percentage of occupied space

        // Calculate the volume of the aquarium in cubic centimeters
        double volumeCm3 = length * width * height;

        // Convert volume to liters (1 liter = 1 dm3 = 1000 cm3)
        double volumeLiters = volumeCm3 / 1000.0;

        // Calculate the actual water volume needed
        double waterLiters = volumeLiters * (1 - percentage / 100.0);

        // Print the result formatted to 2 decimal places
        Console.WriteLine(waterLiters.ToString("F2"));
    }
}
