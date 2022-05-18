using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    class Circle : Shape
    {
        public override double Area(int radius, int height, int width)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
        public override double Perimeter(int radius,int height, int width)
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        public override void QuizQuestions()
        {
            Shape myObj = new Shape();
            myObj.edges = 0;
            myObj.vertices = 0;
            Console.WriteLine("A Circle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2);
            if (PerimeterOrArea == 0)
            {
                Area(7,7,7);
            }
            if (PerimeterOrArea == 1)
            {
                Perimeter(7,7,7); // make it read from CSV file instead 
            }

        }
    }
}
