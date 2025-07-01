// Read an integer number n from the console

int n = int.Parse(Console.ReadLine());

// Initialize variables
int sum = 0;
string result = "";

// Loop from 1 to n to calculate the sum and build the output string
for (int i = 1; i <= n; i++)
{
    sum += i;
    result += i; // Append the current number to the result string

    if (i < n)
    {
        result += "+"; // Add a '+' if it's not the last number
    }
}

// Print the formatted result
Console.WriteLine($"{result}={sum}");