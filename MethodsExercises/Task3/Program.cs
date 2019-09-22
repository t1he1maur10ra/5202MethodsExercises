using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The easy way...*/
            Console.Write("Please enter the last digit on the dollar amount (1-9): ");
            int lastNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Rounding(lastNumber));

            /*The harder way, only for those that wanted to extend themselves, this way of doing it will not be tested.*/
            Console.Write("Please enter the amount you wish to round: ");
            string totalAmount = Console.ReadLine();
            //Treate the string as an array of characters and convert only the last element and pass that through to the method to check.
            Console.WriteLine(Rounding(int.Parse(totalAmount[totalAmount.Length-1].ToString())));
            //Pause the App before it closes and wait for the enter key
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        /*Task 3*/
        static string Rounding(int num)
        {
            string result = "";
            switch(num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    result = "round down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    result = "round up";
                    break;
            }
            return result;
        }
    }
}
