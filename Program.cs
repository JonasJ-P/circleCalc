using System;
using System.Net.NetworkInformation;

namespace lesson3_1
{
    internal class Program{
        static void Main(string[] args)
        {
            CalcProgram();
        }

        public static double CalcAreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static double CalcPerimCircle(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        public static double CheckIfDouble(string input)
        {
            //double testNumber;
            //bool success = double.TryParse(input, out testNumber)
            while(true)
            {
                if(double.TryParse(input, out double inputNumber))
                {
                    return inputNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number");
                    input = Console.ReadLine();
                }
            }
        }

        public static void CalcProgram()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter the radius of the circle");
            string userInput = Console.ReadLine();
            double radius = CheckIfDouble(userInput);
            double area = CalcAreaCircle(radius);
            double perimeter = CalcPerimCircle(radius);
            Console.WriteLine($"The area of the circle is: {area} and the perimeter is: {perimeter}");
        }

    }
}