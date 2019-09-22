using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1and2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1*/
            Console.WriteLine("************************************");
            Console.WriteLine("***** Task 1 - BMI Calculator ******");
            Console.WriteLine("************************************\n");
            //Obtain the users weight and height
            Console.Write("Please enter your weight in kg's: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in cm's: ");
            double height = double.Parse(Console.ReadLine());
            //Call the method, pass the required parameters and display the result
            double bmi = BmiCalculation(weight, height);
            Console.WriteLine($"Your BMI is: {bmi}");

            /*Task 2*/
            Console.WriteLine($"A bmi of {bmi} means you are {BmiClassification(bmi)}");
            //Pause the App before it closes and wait for the enter key
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        /*Task 1*/
        static double BmiCalculation(double w, double h)
        {
            return Math.Round(w / ((h / 100) * (h / 100)));
        }

        /*Task 2*/
        static string BmiClassification(double bmi)
        {
            //check what the value of bmi is a return the appropriate response.
            string result;
            if (bmi < 18.5)
                result = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                result = "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                result = "Overweight";
            else if (bmi >= 30)
                result = "Obese";
            else
                result = "Oops, something went wrong...";
            return result;
        }
    }
}
