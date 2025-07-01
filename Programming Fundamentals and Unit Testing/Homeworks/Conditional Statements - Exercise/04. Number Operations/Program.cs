double num1 = double.Parse(Console.ReadLine());

// Read the second number

double num2 = double.Parse(Console.ReadLine());

// Read the operator

string mathOperator = Console.ReadLine();

double result = 0;

// Perform the operation based on the operator
bool isValidOperation = true;
switch (mathOperator)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
            isValidOperation = false;
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        isValidOperation = false;
        break;
}

// Print the result if the operation is valid
if (isValidOperation)
{
    Console.WriteLine($"{num1} {mathOperator} {num2} = {result:F2}");
}