int SideA = int.Parse(Console.ReadLine());
int SideB = int.Parse(Console.ReadLine());
int SideC  = int.Parse(Console.ReadLine());

// Check if the triangle is valid
if (SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}
    