int hour = int.Parse(Console.ReadLine());   
string day = Console.ReadLine();

bool workingDay = day != "Sunday";

bool workingHour = hour >= 10 && hour <= 18;

if (workingDay && workingHour)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}