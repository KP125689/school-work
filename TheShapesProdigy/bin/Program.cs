using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TheShapesProdigy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Shapes Prodigy!");


            string[] Lines = System.IO.File.ReadAllLines("C:\Users\patrw\Source\Repos\441101-2122-t2-theshapesprodigy-KP125689\TheShapesProdigy\Shapes.csv");

           
            var nameShape = new List<string>();
            var Side1 = new List<string>();
            var Side2 = new List<string>();

            Random Question = new Random();
            int randomInt = Question.Next(1, 62); // generate random number from list
            for (int i = 0; i < randomInt; i++)
            {
                string[] Seperate = Lines[i].Split(",");
                // removes the commas from the CS so its easier to read from
                nameShape.Add(Seperate[0]);
                Side1.Add(Seperate[1]);
                Side2.Add(Seperate[2]);


            }

            for (int i = randomInt - 2; i < nameShape.Count; i++)
            {
                string[] Seperate = Lines[i].Split(",");

                Console.WriteLine(nameShape[i] + " " + Side1[i] + " " + Side2[i]);

            }
        }
    }




    abstract class shape
    {
        private int edges;
        public int Edges
        {
            get { return edges; }
            set { edges = value; }
        }
        private int vertices;
        public int Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }
      

        public abstract double Perimeter();
        public abstract double Area();
        public abstract void QuizQuestions();

       
       
  

    }
    class Square : shape
    {
        public override double Area(int height, int width)
        {
            double area = height * height;
            return area;
        }
        public override double Perimeter(int height, int width)
        {
           double perimeter = 4 * height;
           return perimeter;
        }   
       
        
        public override void QuizQuestions()
        {
            shape myObj = new shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Square has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0,2)
            if(PerimeterOrArea = 0)
            {
                Area();
            }
            if(PerimeterOrArea = 1)
            {
                Perimeter();
            }
         
        }
       
      
    } 
    class Rhombus : shape
    {
        public override double Area(int height, int _base)
        {
           double area = height * _base;
            return area;
        }
        public override double Perimeter(int _base)
        {
            double perimeter = 4 * _base;
            return perimeter;
        }
        
        public override void QuizQuestions()
        {
            shape myObj = new shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Rhombus has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2)
            if (PerimeterOrArea = 0)
            {
                Area();
            }
            if (PerimeterOrArea = 1)
            {
                Perimeter();
            }

        }

    }
    class Rectangle : shape
    {
        public override double Area(int height, int width)
        {
            double area = width * height;
            return area;
        }
        public override double Perimeter(int height, int width)
        {
           double perimeter = 2 * (height + width);
            return perimeter;
        }
       
        public override void QuizQuestions()
        {
            shape myObj = new shape();
            myObj.edges = 4;
            myObj.vertices = 4;
            Console.WriteLine("A Rectangle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2)
            if (PerimeterOrArea = 0)
            {
                Area();
            }
            if (PerimeterOrArea = 1)
            {
                Perimeter();
            }

        }
    }
    class Triangle : shape
    {
        public override double Area(int height, int _base)
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
            shape myObj = new shape();
            myObj.edges = 3;
            myObj.vertices = 3;
            Console.WriteLine("A Triangle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2)
            if (PerimeterOrArea = 0)
            {
                Area();
            }
            if (PerimeterOrArea = 1)
            {
                Perimeter();
            }

        }
    }
    class Circle : shape
    {
        public override double Area(int radius)
        {
            int area = Math.PI * (radius * radius);
            return area;
        }
        public override double Perimeter(int radius)
        {
           int perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
        
        public override void QuizQuestions()
        {
            shape myObj = new shape();
            myObj.edges = 0;
            myObj.vertices = 0;
            Console.WriteLine("A Circle has " + myObj.edges + "and " + myObj.vertices);

            Random rnd = new Random();
            int PerimeterOrArea = rnd.Next(0, 2)
            if (PerimeterOrArea = 0)
            {
                Area();
            }
            if (PerimeterOrArea = 1)
            {
                Perimeter();
            }

        }
    }
        
}
