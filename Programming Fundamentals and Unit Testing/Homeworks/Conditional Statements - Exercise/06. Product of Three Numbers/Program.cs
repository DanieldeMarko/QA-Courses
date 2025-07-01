int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

//int result = a * b * c;

//if (result == 0)
//{
//    Console.WriteLine("zero");

//}
//else if (result > 0)
//{
//    Console.WriteLine("positive");
//}
//else
//{
//    Console.WriteLine("negative");

//}   

int countOfNegative = 0;
if (a < 0)
{
    countOfNegative++;
}
if (b < 0)
{
    countOfNegative++;
}
if (c < 0)
{
    countOfNegative++;
}
if (a == 0 || b == 0 || c == 0) 
{
    Console.WriteLine("zero");
}
else if (countOfNegative == 1 || countOfNegative == 3)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("positive");
}
