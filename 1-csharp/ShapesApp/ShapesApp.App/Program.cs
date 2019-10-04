using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    static class Program
    {
        static void Main(string[] args)
        {
            string input;
            double length;
            do
            {
                Console.WriteLine("Enter a length: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out length));

            double width;
            do
            {
                Console.WriteLine("Enter a width: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out width));

            var rectangle = new Rectangle()
            {
                Length = length,
                Width = width
            };

            rectangle.PrintRectangle();

            double radius;
            do
            {
                Console.WriteLine("enter a radius: ");
                input = Console.ReadLine();
            }while(!double.TryParse(input, out radius));

            ColorCircle colorCircle = new ColorCircle
            {
                Radius = radius,
                Color = "black"
            };

            Console.WriteLine(colorCircle.GetPerimeter());
            Console.WriteLine(ShapeDetails(circle));


            // C# has something called "out" parameters
            // an out parameter cannot have a value before you pass it
        }

        //extension method
        //

        public static void PrintRectangle(this Rectangle r)
        {
            Console.WriteLine($"{r.Length}x{r.Width} rectangle");
            10.ToString();
            int thirtythree = 10.Triple();
        }

        public static string ShapeDetails(IShape shape)
        {
            return $"area {shape.Area}, {shape.Sides}";
        }

        public static int Triple(this int number, int plus = 0)
        {
            return 3 * number + plus;
        }
    }
}
