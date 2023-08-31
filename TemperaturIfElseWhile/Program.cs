using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a number: ");
                string value = Console.ReadLine();
                int number = 0;
                if (int.TryParse(value, out number)) {
                    if (number >= 0)
                    {
                        Console.WriteLine(number + " is positive");
                    } else
                    {
                        Console.WriteLine(number + " is negative");
                    }
                } else
                {
                    Console.WriteLine("invalid input");
                }
            }


        }
    }
}
