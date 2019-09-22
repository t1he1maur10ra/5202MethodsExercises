using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] languages = { "English","Maori", "Japanese", "Hindi", "French", "Samoan"};
            Console.WriteLine("Please select a languae from the following list...");
            for(int i = 0; i < languages.Length; i++)
            {
                Console.WriteLine($"{i+1}. {languages[i]}");
            }
            //Need to subtract 1 because of the array.
            int input = (int.Parse(Console.ReadLine())-1);
            Console.WriteLine($"Hello in {languages[input]} is {Translation(input)}");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        static string Translation(int input)
        {
            //return the appropriate greeting according the the number passed as a parameter.
            string[] greeting = { "Hello", "Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };
            return greeting[input];
        }
    }
}
