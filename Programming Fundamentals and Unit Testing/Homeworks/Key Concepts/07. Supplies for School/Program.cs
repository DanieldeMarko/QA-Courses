int countOfPensPackages = int.Parse(Console.ReadLine());
int countOfMarkersPackages = int.Parse(Console.ReadLine());
int LitersOfBoardCleaner = int.Parse(Console.ReadLine());
int DiscountPercentage = int.Parse(Console.ReadLine());

double priceForPens = countOfPensPackages * 5.80;
double priceForMarkers = countOfMarkersPackages * 7.20;
double priceForLiters = LitersOfBoardCleaner * 1.20;

double priceForMaterials = priceForPens + priceForMarkers + priceForLiters;

double discount = priceForMaterials * DiscountPercentage / 100;

double finalPrice = priceForMaterials - discount;
Console.WriteLine(finalPrice);


