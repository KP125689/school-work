using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    class Rhombus : Shape
    {
        public override double Area(int height, int _base, int width)
        {
            double area = height * _base;
            return area;
        }
        public override double Perimeter(int _base, int height, int width)
        {
            double perimeter = 4 * _base;
            return perimeter;
        }

        public override void QuizQuestions()
        {
            Shape myObj = new Shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Rhombus has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2);
            if (PerimeterOrArea == 0)
            {
                Area(1,1,1);
            }
            if (PerimeterOrArea == 1)
            {
                Perimeter(7,7,7); // make it take from values from CSv file
            }

        }

    }
}
