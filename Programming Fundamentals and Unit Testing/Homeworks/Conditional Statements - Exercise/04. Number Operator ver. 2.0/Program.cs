using System.ComponentModel.Design;

namespace _04._Number_Operator_ver._2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = double.Parse(Console.ReadLine());

            // Read the second number

            double num2 = double.Parse(Console.ReadLine());

            // Read the operator

            string mathOperator = Console.ReadLine();

            if (mathOperator == "+")

            {
                Console.WriteLine($"{num1} {mathOperator} {num2} = {num1 + num2}" : F2);
            }

            else if (mathOperator == "-")
            {
                Console.WriteLine($"{num1} {mathOperator} {num2} = {num1 - num2}");
            }
            else if (mathOperator == "*")
            {
                Console.WriteLine($"{num1} {mathOperator} {num2} = {num1 * num2}");
            }
            else
            {
                Console.WriteLine($"{num1} {mathOperator} {num2} = {num1 / num2}");
            }
        }
    }
}

