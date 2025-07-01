int nylonSqM = int.Parse(Console.ReadLine());
int paintLt = int.Parse(Console.ReadLine());    
int ThinnerQty = int.Parse(Console.ReadLine());
int HourseNeededCraftsmman = int.Parse(Console.ReadLine());

double nylonAmount = (nylonSqM + 2) * 1.50;
double AmountPaint = (paintLt * 1.10) * 14.50;
double AmountThinner = ThinnerQty * 5.00;
double AmountBags = 0.40;

double TotalAmount = nylonAmount + AmountPaint + AmountThinner + AmountBags;
double Craftsmanship = TotalAmount * 0.30 * HourseNeededCraftsmman;
double TotalAmount2 = TotalAmount + Craftsmanship;

Console.WriteLine(TotalAmount2);
