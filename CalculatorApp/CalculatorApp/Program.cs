using System;

namespace CalculatorApp  // Add this namespace
{
    public class Calculator
    {
        public static double Calculate(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/':
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result = Calculator.Calculate(num1, op, num2);
                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
