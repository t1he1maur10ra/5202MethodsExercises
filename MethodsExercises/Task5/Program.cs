using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the operation you would like to perform (+,-,*,/,%): ");
            string op = Console.ReadLine();
            Console.WriteLine($"{num1} {op} {num2} = {Calc(num1,num2,op)}");

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        static double Calc(double num1, double num2, string op)
        {
            double result = 0;

            /*Check which opperator needs to bu used*/
            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = Math.Round((num1 / num2), 2);
            else if (op == "%")
                result = num1 % num2;

            return result;
        }
    }
}
