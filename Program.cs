using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /):");
            char op = char.Parse(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }
    }
}
