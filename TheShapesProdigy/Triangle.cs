using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    class Triangle : Shape
    {
        public override double Area(int height, int _base, int width)
        {
            double area = 0.5 * (height * _base);
            return area;
        }
        public override double Perimeter(int height, int _base, int diagonal)
        {
            double diagonalLength = Math.Sqrt((height * height) + (_base * _base));
            double perimeter = height + diagonalLength + _base;
            return perimeter;
        }

        public override void QuizQuestions()
        {
            Shape myObj = new Shape();
            myObj.edges = 3;
            myObj.vertices = 3;
            Console.WriteLine("A Triangle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2);
            if (PerimeterOrArea == 0)
            {
                Area(1,1,1);
            }
            if (PerimeterOrArea == 1)
            {
                Perimeter(7,7,7); // make it read from CSV file
            }

        }
    }
}
