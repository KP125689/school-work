using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    class Square : Shape
    {
        public override double Area(int height, int width, int radius)
        {
            double area = height * height;
            return area;
        }
        public override double Perimeter(int height, int width, int radius)
        {
            double perimeter = 4 * height;
            return perimeter;
        }


        public override void QuizQuestions()
        {
            Shape myObj = new Shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Square has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2);
            if (PerimeterOrArea == 0)
            {
                Area(1,1,1);
            }
            if (PerimeterOrArea == 1)
            {
                Perimeter(7,7,7); // make it read from CSV file and do the maths 
            }

        }


    }
}
