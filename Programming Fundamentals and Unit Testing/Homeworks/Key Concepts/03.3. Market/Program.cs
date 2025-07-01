// Input
double tomatoPricePerKilo = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPricePerKilo = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

//Calculations

double tomatoPrice = tomatoQuantity * tomatoPricePerKilo;
double cucumberPrice = cucumberPricePerKilo * cucumberQuantity;
double finalPrice = tomatoPrice + cucumberPrice;

Console.WriteLine($"{finalPrice:F2}");  
