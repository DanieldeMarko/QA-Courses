char letter = char.Parse(Console.ReadLine());

//Output
switch (char.ToLower(letter)) //because C# case sensitive
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vowel");
        break;
    default:
        if (char.IsLetter(letter))
        {
            Console.WriteLine("Consonant");
        }
        else
        {
            Console.WriteLine("Invalid input");
          
        }
        break;
}
