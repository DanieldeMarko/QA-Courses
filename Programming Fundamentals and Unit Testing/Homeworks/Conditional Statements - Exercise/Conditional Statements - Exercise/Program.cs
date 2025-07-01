
int number;

// Read the input and parse it as an integer
if (int.TryParse(Console.ReadLine(), out number))
{
    // Check the value of the number and print the corresponding message
    if (number < 0)
    {
        Console.WriteLine("negative");
    }
    else if (number > 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("zero");
    }
}
else
{
    // Handle invalid input
    Console.WriteLine("Invalid input. Please enter an integer number.");
}