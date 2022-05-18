using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    class Rectangle : Shape
    {
        public override double Area(int height, int width, int radius)
        {
            double area = width * height;
            return area;
        }
        public override double Perimeter(int height, int width, int radius)
        {
            double perimeter = 2 * (height + width);
            return perimeter;
        }

        public override void QuizQuestions()
        {
            Shape myObj = new Shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Rectangle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2);
            if (PerimeterOrArea == 0)
            {
                Area(7,7,7);
            }
            if (PerimeterOrArea == 1)
            {
                Perimeter(1,1,1); // make read from CSV file later
            }

        }
    }
}
