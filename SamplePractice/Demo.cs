using System;

namespace SamplePractice
{
    class Demo
    {

        static void Main(string[] args)
        {

            double num1;
            double num2;
            string operand;
            double answer;

            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operand)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

        }

    }
}