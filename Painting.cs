using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimonsShapes;


namespace The_Cost_of_Art
{
    public class Painting : ValidatePainting
    {
        private string newTitle;
        public string NewTitle { get { return newTitle; } set { newTitle = value; } }


        public void EditPainting()
        {

            Console.WriteLine(ConstStrings.SELECT_ACTION);
            Console.WriteLine("1. Add new shape.");
            Console.WriteLine("2. Edit existing shape.");
            Console.WriteLine("3. Remove existing shape.");
            Console.WriteLine("4. Stop editing painting.");
            Console.WriteLine("5. Exit program.");
            Console.WriteLine("\n");
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 1, 5);
            string inputChoice = Console.ReadLine();
            // not finsihed

        }
        public void NewPainting()
        {
            // to create new painting 
            Console.WriteLine(ConstStrings.ENTER_TITLE);
            NewTitle = Console.ReadLine();
            trimTitle();
        }
        public bool trimTitle() //trim title name to correct length
        {
            if (NewTitle.Trim().Length >= 4)
            {
                return true;

            }
            else
            {
                Console.WriteLine(ConstStrings.INVALID_TITLE);
                NewPainting();
                return false;

            }
        }
    }
}