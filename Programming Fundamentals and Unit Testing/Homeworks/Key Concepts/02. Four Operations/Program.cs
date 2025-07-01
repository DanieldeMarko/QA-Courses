double firstNumber = double.Parse(Console.ReadLine());
double SecondNumber = double.Parse(Console.ReadLine());

double additionResult = firstNumber + SecondNumber;
double subtractResult = firstNumber - SecondNumber;
double multiplicationResult = firstNumber * SecondNumber;
double divideResult = firstNumber / SecondNumber;

Console.WriteLine($"{firstNumber:F2} + {SecondNumber:F2} = {additionResult:F2}");
Console.WriteLine($"{firstNumber:F2} - {SecondNumber:F2} = {subtractResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {SecondNumber:F2} = {multiplicationResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {SecondNumber:F2} = {divideResult:F2}");



