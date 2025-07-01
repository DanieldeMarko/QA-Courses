char letter = char.Parse(Console.ReadLine());

// Check if the character is a vowel or consonant using switch
switch (char.ToLower(letter)) // Convert to lowercase for case-insensitive comparison
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        if (char.IsLetter(letter)) // Check if it's an alphabet character
        {
            Console.WriteLine("Consonant");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        break;
}