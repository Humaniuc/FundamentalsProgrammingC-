using System;

namespace HypotenuseFind
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide;
            double secondSide;
            while (true)
            {
                Console.Write("Write a positive number (sideA): ");
                if (double.TryParse(Console.ReadLine(), out firstSide) && firstSide > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a positive number.");
                }
            }

            while (true)
            {
                Console.Write("Write a positive number (sideB): ");
                if (double.TryParse(Console.ReadLine(), out secondSide) && secondSide > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a positive number.");
                }
            }   

            Console.WriteLine($"Hypotenuse of right triangle with sides {firstSide} and {secondSide} is {Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)):f2}");
            
        }
    }
}
