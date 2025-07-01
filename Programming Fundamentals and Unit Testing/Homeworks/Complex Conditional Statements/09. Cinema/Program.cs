
// четем от конзолата
string movieType = (Console.ReadLine());
int rows = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

// това аджеба откъде дойде
double pricePerSeat;

// вид филм
switch (movieType)
{
    case "Premiere":
        pricePerSeat = 12.00;
        break;
    case "Normal":
        pricePerSeat = 7.50;
        break;
    case "Discount":
        pricePerSeat = 5.00;
        break;
    default:
        Console.WriteLine("Invalid movie type");
        return;
}


        // Calculate the total price
        double totalPrice = rows * seatsPerRow * pricePerSeat;

// Print the total price formatted to 2 decimal places
Console.WriteLine($"{totalPrice:F2}");
    