using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimonsShapes;
using System.Threading.Tasks;

namespace The_Cost_of_Art
{

    public class Circle
    {
        private int radius;
        private string fillColourName;
        private string outlineColourName;
        private float outlineThickness;

        public int _radius
        {
            get { return radius; } //return radius of circle
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
            get { return outlineThickness; } // returns the thickness of the outline of the shape
        }

        public bool checkRadius(int _Radius)
        {
            if (_Radius >= 5 && _Radius <= 50)
            {
                return true; // checks height
            }
            else
            {
                return false;
            }
        }

        public bool checkCicleColour(int _ChooseNumber)
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
        public bool checkCircleOutline(int _chooseNumber2)
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
        public void radiusCircle() // takes in the users desired height (method)
        {
            Console.WriteLine(ConstStrings.ENTER_NEW_RADIUS);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 5, 50);
            string newRadius = Console.ReadLine();
            int radius = Convert.ToInt32(newRadius);
            
            if (checkRadius(radius))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, radius, 5, 50 + " or " + radius + ConstStrings.NOT_WHOLE_NUMBER);
                radiusCircle();
            }

        }
        public void CircleColour() // takes in the users desired colour
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
            string newCircleColourName = Console.ReadLine();
            int colour = Convert.ToInt32(newCircleColourName);
            
            if (checkCicleColour(colour))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, colour, 1, 9 + " or " + colour + ConstStrings.NOT_WHOLE_NUMBER);
                CircleColour();
            }

        }
        public void CircleOutlineColourName() // takes in the users desired outline colour
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
            string newCircleOultineName = Console.ReadLine();
            int outline = Convert.ToInt32(newCircleOultineName);
            
            if (checkCircleOutline(outline))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, outline, 1, 9 + " or " + outline + ConstStrings.NOT_WHOLE_NUMBER);
                CircleOutlineColourName();
            }
        }
        public void circleOutlineThickness() // takes in the users desired thickness
        {
            Console.WriteLine(ConstStrings.SELECT_NEW_OUTLINE_THICKNESS);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 0.1, 5);
            string newCircleThicknessSize = Console.ReadLine();
            float thickness = float.Parse(Console.ReadLine());
            
            if (checkThickness(thickness))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, thickness, 0.1, 5 + " or " + thickness + ConstStrings.NOT_WHOLE_NUMBER);
                CircleOutlineColourName();
            }

        }
    }
}
