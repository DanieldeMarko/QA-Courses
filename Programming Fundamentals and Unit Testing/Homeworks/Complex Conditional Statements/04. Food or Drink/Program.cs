// Convert to lowercase for consistent comparison
string product = Console.ReadLine().ToLower(); 

// Determine the type of product and print the result
if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
{
    Console.WriteLine("food");
}
else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
{
    Console.WriteLine("drink");
}
else
{
    Console.WriteLine("unknown");
}
