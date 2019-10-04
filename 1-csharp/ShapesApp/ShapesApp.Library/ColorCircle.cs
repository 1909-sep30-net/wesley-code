using System;

namespace ShapesApp.Library
{
    public class ColorCircle : Circle
    {
        public  string Color { get; set;}

        //method hiding is possible on non-virtual methods
        //but you get a warning unless you indicate that with the "new"
        // 

        public new double GetPerimeter()
        {
            Console.WriteLine("calculating perimeter");
            //return 2 * Math.PI *Radius;
            return base.GetPerimeter();
        }
    }
}