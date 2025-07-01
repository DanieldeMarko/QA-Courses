
int points = int.Parse(Console.ReadLine());

// Initialize bonus points
int bonusPoints = 0;

// Determine bonus based on points range
if (points >= 0 && points <= 3)
{
    bonusPoints = 5;
}
else if (points >= 4 && points <= 6)
{
    bonusPoints = 15;
}
else if (points >= 7 && points <= 9)
{
    bonusPoints = 20;
}

// Calculate final points
int finalPoints = points + bonusPoints;

// Output final points
Console.WriteLine($"{finalPoints}");