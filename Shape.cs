using System;
using SimonsShapes;


namespace The_Cost_of_Art
{
    public class Shape : Painting
    {
        //creating the parameters for each shape (objects)
        public void SquareShape()
        {
            Square square = new Square();
            square.squareOutlineColourName();
            square.squareOutlineThickness();
            square.SquareHeight();
            square.SquareColour();
        }
        public void RectangleShape()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.rectangleHeigt();
            rectangle.recWidth();
            rectangle.RecColour();
            rectangle.recOutlineColourName();   
            rectangle.recOutlineThickness();
        }
        public void CircleShape()
        {
            Circle circle = new Circle();
            circle.radiusCircle();
            circle.CircleColour();
            circle.CircleOutlineColourName();   
            circle.circleOutlineThickness();

          
        }
        public void TriangleShape()
        {
            Triangle triangle = new Triangle();
            triangle.TriangleColour();
            triangle.TriangleHeight();
            triangle.traingleOutlineThickness();
            triangle.triangleOutlineColourName();
            
        }
        public void SelectShape(string NewTitle)
        {
            NewPainting();
            Console.WriteLine("Please select shape to add to : " + NewTitle); // user has to select a shape 
            Console.WriteLine("1. Square. ");
            Console.WriteLine("2. Rectangle. ");
            Console.WriteLine("3. Circle. ");
            Console.WriteLine("4. Triangle. ");
            Console.WriteLine("5. Exit program. ");
            Console.WriteLine("\n");
            Console.WriteLine(string.Format(ConstStrings.VALUE_MIN_MAX, 1, 5));
            string shape = Console.ReadLine();
            int shapeChoice = Convert.ToInt32(shape);

            switch (shapeChoice)
            {
                case 1:
                    SquareShape();
                    break;
                case 2:
                    RectangleShape();
                    break;
                case 3:
                    CircleShape();
                    break;
                case 4:
                    TriangleShape();
                    break;
                case 5:
                    Console.WriteLine(ConstStrings.EXIT);
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(ConstStrings.NOT_IN_RANGE, shapeChoice, 1, 5 + " or " + shapeChoice + ConstStrings.NOT_WHOLE_NUMBER);
                    break;
            }

            
        }
        public void newShape() //method to use in main class
        {
            SelectShape(NewTitle);
        }
    }
}
