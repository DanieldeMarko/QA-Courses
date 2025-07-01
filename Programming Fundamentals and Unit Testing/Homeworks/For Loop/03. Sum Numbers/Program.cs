int n = int.Parse(Console.ReadLine());

double sum = 0;

// Read n floating-point numbers and calculate the sum
for (int i = 1; i <= n; i++)
{
 
    double number = double.Parse(Console.ReadLine());
    sum += number;
}

// Print the total sum
Console.WriteLine($"{sum}");