// Input
string product = Console.ReadLine();
string typeOfDay = Console.ReadLine();

if (typeOfDay == "Weekday") 
{
    if (product == "Banana")
        Console.WriteLine("2.50");
   else if (product == "Apple")
            Console.WriteLine("1.30");
        else if (product == "Kiwi")
            Console.WriteLine("2.20");
    
}
else if (typeOfDay == "Weekend")
{ 
            if (product == "Banana")
            Console.WriteLine("2.70");
        else if (product == "Apple")
                Console.WriteLine("1.60");
            else if (product == "Kiwi")
                Console.WriteLine("3.00");
    
    }
