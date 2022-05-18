using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimonsShapes;


namespace The_Cost_of_Art
{
    public class Square
    {
        private int height;        
        private string fillColourName;
        private string outlineColourName;
        private float outlineThickness;

        public int _Height
        {
            get { return height; } //return height of square
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
            get { return outlineThickness; } // returns the thickness of the outline of the square
        }

        public bool checkHieght(int _height)
        {
            if (_height >=5 && _height < 51)
            {
                return true; // checks height
            }
            else
            {
                return false;
            }
        }
        public bool checkSquareColour(int _ChooseNumber)
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
        public bool checkSquareOutline(int _chooseNumber2)
        {
            if (_chooseNumber2 >= 1 && _chooseNumber2 < 10)
            {
                return true; // checks its on the list
            }
            else
            {
                return false;
            }
        }
        public bool checkThickness(float _Thick)
        {
            if (_Thick >= 0.1 && _Thick <= 5)
            {
                return true; // checks its within range
            }
            else
            {
                return false;
            }
        }

        public void SquareHeight() // takes in the users desired height (method)
        {
            Console.WriteLine(ConstStrings.ENTER_NEW_SQUARE_HEIGHT);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 5, 50);
            string newSquareHeight = Console.ReadLine();
            int height = Convert.ToInt32(newSquareHeight);
            
            if (checkHieght(height))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, height, 5, 50 + " or " + height + ConstStrings.NOT_WHOLE_NUMBER);
                SquareHeight();
            }

        }
        public void SquareColour() // takes in the users desired colour
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
            string newSquareColourName = Console.ReadLine(); 
            int colour = Convert.ToInt32(newSquareColourName);
            
            if (checkSquareColour(colour))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, colour, 1, 9 + " or " + colour + ConstStrings.NOT_WHOLE_NUMBER);
                SquareColour();
            }

        }
        public void squareOutlineColourName() // takes in the users desired outline colour
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
            string newSquareOultineName = Console.ReadLine();
            int outline = Convert.ToInt32(newSquareOultineName);
            
            if (checkSquareOutline(outline))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, outline, 1, 9 + " or " + outline + ConstStrings.NOT_WHOLE_NUMBER);
                squareOutlineColourName();
            }
        }
        public void squareOutlineThickness() // takes in the users desired thickness
        {
            Console.WriteLine(ConstStrings.SELECT_NEW_OUTLINE_THICKNESS);
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 0.1, 5);
            string newSquareThicknessSize = Console.ReadLine();
            float thickness = float.Parse(Console.ReadLine());
           
            if (checkThickness(thickness))
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, newSquareThicknessSize, 0.1, 5 + " or " + newSquareThicknessSize + ConstStrings.NOT_WHOLE_NUMBER);
                squareOutlineThickness();
            }

        }


    }
}
