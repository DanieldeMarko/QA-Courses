int countOfPagesToRead = int.Parse(Console.ReadLine());
int PagesReadPerHour = int.Parse(Console.ReadLine());
int TheNumberOfDays = int.Parse(Console.ReadLine());

int neededHoursToRead = countOfPagesToRead / PagesReadPerHour;
int readingHoursPerDay = neededHoursToRead / TheNumberOfDays;

Console.WriteLine(readingHoursPerDay);