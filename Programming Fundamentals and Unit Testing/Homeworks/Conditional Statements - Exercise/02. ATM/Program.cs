
int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

// Check the conditions for the withdrawal
if (withdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (withdraw > balance)
{
    Console.WriteLine("Insufficient availability.");
}
else
{
    Console.WriteLine("The withdraw was successful.");
}