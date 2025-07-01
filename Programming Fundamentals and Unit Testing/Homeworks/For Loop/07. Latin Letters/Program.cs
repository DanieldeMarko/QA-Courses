char startLetter = Convert.ToChar(Console.ReadLine());
char endLetter = Convert.ToChar(Console.ReadLine());

// Ensure the start letter comes before the end letter
if (startLetter > endLetter)
{
    char temp = startLetter;
    startLetter = endLetter;
    endLetter = temp;
}

// Print all letters in the specified range horizontally
for (char c = startLetter; c <= endLetter; c++)
{
    Console.Write(c + " ");
}

