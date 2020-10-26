using System;

namespace MethodArea
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

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = CalculateArea (20);

            Console.WriteLine($"The area of a circle with radius of {20} is {CalculateArea(20)}");

        }

        public static double CalculateArea(double radius)
        {

            return Math.PI * (radius * radius);
        }
    }
}
