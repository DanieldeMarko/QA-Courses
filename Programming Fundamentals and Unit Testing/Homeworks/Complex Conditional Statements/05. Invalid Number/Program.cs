int num = int.Parse(Console.ReadLine());

// Check if the number is not in the valid range [100...200] or equals to 0
bool isValid = (num >= 100 && num <= 200) || num == 0;
if (!isValid)
{
    Console.WriteLine("invalid");
}