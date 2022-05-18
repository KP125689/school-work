using System;
using System.Collections.Generic;
using System.Text;

namespace TheShapesProdigy
{
    public abstract class Shape
    {
        public int edges;
        
        public int vertices;

        public abstract double Perimeter(int height, int width, int radius);
        public abstract double Area(int height, int width, int radius);
        public abstract void QuizQuestions();
    }
}
