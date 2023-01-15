using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    //class Getting_and_calculation_an_expression
    //{
    //    double variable;
    //    int max_priority;
    //    List<string> operations = new List<string> { "!", "+", "-", "%", "/", "*", "^" };
    //    public void Initialisation(ref string s)
    //    {
    //        Console.WriteLine("The output of the calculations and the result");
    //        string[] subs = s.Split(' ');
    //        bool condition = true;
    //        while (condition)
    //        {
    //            max_priority = 0;
    //            foreach (var sub in subs)
    //            {
    //                bool result = double.TryParse(sub, out variable);
    //                if (result)
    //                {
    //                }
    //                else
    //                {
    //                    for (int i = 0; i < operations.Count; i++)
    //                    {
    //                        if (operations[i] == sub && i > max_priority)
    //                        {
    //                            max_priority = i;
    //                        }
    //                    }
    //                }
    //            }
    //            if (max_priority == 0)
    //            {
    //                condition = false;
    //                Array.Resize(ref subs, subs.Length - 2);
    //                Console.WriteLine("Answer : ");
    //                Console.WriteLine(String.Join(" ", subs));
    //                break;
    //            }
    //            else
    //            {
    //                for (int k = 0; k < subs.Length; k++)
    //                {
    //                    double result;
    //                    if (subs[k] == operations[max_priority])
    //                    {
    //                        if (subs[k]== "+"| subs[k] == "-"| subs[k] == "*" | subs[k] == "^" )
    //                        {
    //                            result = double.Parse(subs[k - 1]) + double.Parse(subs[k + 1]);
    //                            subs[k] = Convert.ToString(result);
    //                        }
    //                        if (subs[k] == "%" | subs[k] == "/")
    //                        {
    //                            if (double.Parse(subs[k + 1]) != 0.0)
    //                            {
    //                                result = double.Parse(subs[k - 1]) % double.Parse(subs[k + 1]);
    //                                subs[k] = Convert.ToString(result);
    //                            }
    //                            else
    //                                Console.WriteLine(" На ноль не делится! Ошибка!");
    //                        }

    //                        for (int j = (k - 1); j < subs.Length - 1; j++)
    //                        {
    //                            subs[j] = subs[j + 1];
    //                        }
    //                        Array.Resize(ref subs, subs.Length - 1);

    //                        for (int j = k; j < subs.Length - 1; j++)
    //                        {
    //                            subs[j] = subs[j + 1];
    //                        }
    //                        Array.Resize(ref subs, subs.Length - 1);

    //                        Console.WriteLine(String.Join(" ", subs));
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}
    static class Calculation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Dif(int a, int b)
        {
            return a - b;
        }
        public static int Remain(int a, int b)
        {
            return a % b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Deg(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(a, b));
        }
    }
}
