using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimonsShapes;
using System.Threading.Tasks;

namespace The_Cost_of_Art
{
    public class Triangle
    {
        private int side;
        private string fillColourName;
        private string outlineColourName;
        private float outlineThickness;

        public int _side
        {
            get { return side; } //returns te side length of the triangle
        }
        public string _fillcolor
        {
            get { return fillColourName; } // return name of the colour used
        }
        public string _outlineColourName
        {
            get { return outlineColourName; } // return the name of the colour that will outline the shape
        }
        public float _outlineThickness
        {
            get { return outlineThickness; } // returns the thickness of the outline of the triangle
        }

        public bool checkSide(int _Side)
        {
            if (_Side >= 5 && _Side <= 50)
            {
                return true; // checks side length
            }
            else
            {
                return false;
            }
        }

        public bool checktriangleColour(int _ChooseNumber)
        {
            if (_ChooseNumber >= 1 && _ChooseNumber < 10)
            {
                return true; // checks its within range
            }
            else
            {
                return false;
            }
        }
        public bool checkTriangleOutline(int _chooseNumber2)
        {
            if (_chooseNumber2 >= 1 && _chooseNumber2 < 10)
            {
                return true; // checks colour is on the list
            }
            else
            {
                return false;
            }
        }
        public bool checkThickness(float _Thick)
        {
            if (_Thick > 0.1 && _Thick <= 5)
            {
                return true; // checks its within range
            }
            else
            {
                return false;

            }

        }
        public void TriangleHeight() // takes in the users desired height (method)
        {
            Console.WriteLine(ConstStrings.ENTER_NEW_SIDE);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 5, 50);
            string newTriangleHeight = Console.ReadLine();
            int height = Convert.ToInt32(newTriangleHeight);
            
            if (checkSide(height))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, height, 5, 50 + " or " + height + ConstStrings.NOT_WHOLE_NUMBER);
                TriangleHeight();
            }


        }
        public void TriangleColour() // takes in the users desired colour
        {
            Console.WriteLine(ConstStrings.SELECT_NEW_FILL_COLOUR);
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
            Console.WriteLine("4. Indigo");
            Console.WriteLine("5. Orange");
            Console.WriteLine("6. Red");
            Console.WriteLine("7. Violet");
            Console.WriteLine("8. Yelloe");
            Console.WriteLine("9. White");
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 1, 9);
            string newTriangleColourName = Console.ReadLine();
            int colour = Convert.ToInt32(newTriangleColourName);
           
            if (checktriangleColour(colour))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, colour, 1, 9 + " or " + colour + ConstStrings.NOT_WHOLE_NUMBER);
                TriangleColour();
            }

        }
        public void triangleOutlineColourName() // takes in the users desired outline colour
        {
            Console.WriteLine(ConstStrings.SELECT_NEW_OUTLINE_COLOUR);
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
            Console.WriteLine("4. Indigo");
            Console.WriteLine("5. Orange");
            Console.WriteLine("6. Red");
            Console.WriteLine("7. Violet");
            Console.WriteLine("8. Yelloe");
            Console.WriteLine("9. White");
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 1, 9);
            string newTriangleOultineName = Console.ReadLine();
            int outline = Convert.ToInt32(newTriangleOultineName);
            
            if (checkTriangleOutline(outline))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, outline, 1, 9 + " or " + outline + ConstStrings.NOT_WHOLE_NUMBER);
                triangleOutlineColourName();
            }
        }
        public void traingleOutlineThickness() // takes in the users desired thickness
        {
            Console.WriteLine(ConstStrings.SELECT_NEW_OUTLINE_THICKNESS);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 0.1, 5);
            string newTriangleThicknessSize = Console.ReadLine();
            float thickness = float.Parse(Console.ReadLine());
           
            if (checkThickness(thickness))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, thickness, 0.1, 5 + " or " + thickness + ConstStrings.NOT_WHOLE_NUMBER);
                traingleOutlineThickness();
            }

        }
    }

    
}
