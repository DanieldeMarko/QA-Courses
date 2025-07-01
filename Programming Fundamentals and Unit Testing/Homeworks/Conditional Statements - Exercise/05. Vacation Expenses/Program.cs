// Вход
string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());
double pricepernight = 0;

if (season == "Spring")
{
    if (accomodationType == "Hotel")
    {
        pricepernight = 30 * countOfDays;
        pricepernight = pricepernight - (pricepernight * 0.2);
    }

    else
    {
        pricepernight = 10 * countOfDays;
        pricepernight = pricepernight - (pricepernight * 0.2);
    }
}
else if (season == "Summer")

{
    if (accomodationType == "Hotel")
    {
        pricepernight = 50 * countOfDays;

    }
    else
    {
        pricepernight = 30 * countOfDays;

    }
}
else if (season == "Autumn")

{
    if (accomodationType == "Hotel")
    {
        pricepernight = 20 * countOfDays;
        pricepernight = pricepernight - (pricepernight * 0.3);
    }
    else
    {
        pricepernight = 15 * countOfDays;
        pricepernight = pricepernight - (pricepernight * 0.3);
    }
}
else if (season == "Winter")

{
    if (accomodationType == "Hotel")
    { 
        pricepernight = 40 * countOfDays;
        pricepernight = pricepernight - (pricepernight * 0.1);
    }
else
{
    pricepernight = 10 * countOfDays;
    pricepernight = pricepernight - (pricepernight * 0.1);
  }
}
    
        Console.WriteLine($"{pricepernight:F2}");