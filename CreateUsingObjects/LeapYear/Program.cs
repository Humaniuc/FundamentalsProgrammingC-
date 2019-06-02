using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Write a number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            } while (true);

            if ((number % 4 == 0) || (number % 100 == 0 && number % 400 == 0))
            {
                Console.WriteLine($"Conditions: Number {number} is LeapYear");
            }
            else
            {
                Console.WriteLine("Not leap Year");
            }

            if (DateTime.IsLeapYear(number))
            {
                Console.WriteLine($"Framework: Number {number} is LeapYear");
            }
            else
            {
                Console.WriteLine("Not leap Year");
            }


            Console.ReadLine();
        }
    }
}
