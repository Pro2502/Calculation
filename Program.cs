using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using operators:");
            Console.WriteLine("'+' addition\n'-' subtraction\n'*' multiplication\n'/' division\n'^' degree\n'%' remainder of the division\n");
            Console.WriteLine("write your expression separated by spaces:\n");
            string s = Console.ReadLine();

            Getting_and_calculation_an_expression getting_and_calculation_an_expression = new Getting_and_calculation_an_expression();
            getting_and_calculation_an_expression.Initialisation(ref s);
        }
    }
}
