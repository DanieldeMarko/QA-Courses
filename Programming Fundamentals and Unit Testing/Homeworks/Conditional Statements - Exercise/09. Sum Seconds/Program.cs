int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3  = int.Parse(Console.ReadLine());

int TotalTIme = time1 + time2+ time3;

int minutes = TotalTIme / 60;
int seconds = TotalTIme % 60;

Console.WriteLine($"{minutes}:{seconds :D2}");
