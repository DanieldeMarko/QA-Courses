﻿int temperature = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();

string clothing = "";
string shoes = "";

// Determine the clothing and shoes based on temperature and time of day
if (temperature >= 10 && temperature <= 18)
{
    if (timeOfDay == "Morning")
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}
else if (temperature > 18 && temperature <= 24)
{
    if (timeOfDay == "Morning")
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (timeOfDay == "Afternoon")
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfDay == "Evening")
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}
else if (temperature >= 25)
{
    if (timeOfDay == "Morning")
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfDay == "Afternoon")
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (timeOfDay == "Evening")
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}

// Print the recommendation
Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
