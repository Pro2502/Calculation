using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Using operators:");
            //Console.WriteLine("'+' addition\n'-' subtraction\n'*' multiplication\n'/' division\n'^' degree\n'%' remainder of the division\n");
            //Console.WriteLine("write your expression separated by spaces:\n");
            //string s = Console.ReadLine();

            //Getting_and_calculation_an_expression getting_and_calculation_an_expression = new Getting_and_calculation_an_expression();
            //getting_and_calculation_an_expression.Initialisation(ref s);

            Console.WriteLine("Enter the first number");
            int firtValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an action:");
            Console.WriteLine("'+' addition\n'-' subtraction\n'*' multiplication\n'/' division\n'^' degree\n'%' remainder of the division\n");
            string s = Console.ReadLine();
            Console.WriteLine("The calculated value is: ");
            switch (s)
            {
                case "+":
                    Console.WriteLine(Calculation.Sum(firtValue, secondValue));
                    break;
                case "-":
                    Console.WriteLine(Calculation.Dif(firtValue, secondValue));
                    break;
                case "%":
                    if (secondValue != 0.0)
                    {
                        Console.WriteLine(Calculation.Remain(firtValue, secondValue));
                    }
                    else
                        Console.WriteLine(" На ноль не делится! Ошибка!");
                    break;
                case "*":
                    Console.WriteLine(Calculation.Mult(firtValue, secondValue));
                    break;
                case "/":
                    if (secondValue != 0.0)
                    {
                        Console.WriteLine(Calculation.Div(firtValue, secondValue));
                    }
                    else
                        Console.WriteLine(" На ноль не делится! Ошибка!");
                    break;
                case "^":
                    Console.WriteLine(Calculation.Deg(firtValue, secondValue));
                    break;
                default:
                    Console.WriteLine("Неправильная операция!");
                    break;
            }
        }
        }
}
