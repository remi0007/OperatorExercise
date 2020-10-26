using System;

namespace Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($" {a} / {b} is {div} remainder {mod}");

            // Allow user to input the radius

            Console.WriteLine("What is the area of a circle?");
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = CalculateArea(radius);

            // Calculate area of the circle

            Console.WriteLine($"The area of a circle with radius of {20} is {CalculateArea(20)}");

        }

        public static double CalculateArea(double radius)
        {

            return Math.PI * (radius * radius);
        }
    }
}
