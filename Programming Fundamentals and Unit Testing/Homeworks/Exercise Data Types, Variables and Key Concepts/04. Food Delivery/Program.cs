double chickenmenu = double.Parse(Console.ReadLine());
double MenuFish = double.Parse(Console.ReadLine());
double VegeterianMenu = double.Parse(Console.ReadLine());
double deliveryprice = 2.50;

double priceChickenMenu = chickenmenu * 10.35;
double priceMenuFish = MenuFish * 12.40;
double priceVegeterianMenu = VegeterianMenu * 8.15;

double TotalCostMenu = priceChickenMenu + priceMenuFish + priceVegeterianMenu;
double priceDessert = TotalCostMenu * 0.20;
double TotalOrderPrice = TotalCostMenu + priceDessert + deliveryprice;

Console.WriteLine(TotalOrderPrice);
