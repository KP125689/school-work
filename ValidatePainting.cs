using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimonsShapes;

namespace The_Cost_of_Art
{
    public class ValidatePainting
    {
        public void LoadPaintings() //loads panting for user from file.
        {
            int count = 0;
            string[] paintingFiles = Directory.GetFiles("Paintings", "*.pnt");
            foreach (string name in paintingFiles)
            {
                Console.WriteLine(count + ". " + name);
                count++;
            }
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 1, paintingFiles.Length);
            string painting = Console.ReadLine();
            int loadpaint = Convert.ToInt32(painting);
            if (loadpaint >= 1 && loadpaint <= paintingFiles.Length)
            {
                // do stuff
            }
            else
            {
                Console.WriteLine(ConstStrings.NOT_IN_RANGE, painting, 1, paintingFiles.Length + " or " + painting + ConstStrings.NOT_WHOLE_NUMBER);
                LoadPaintings();
            }
        }
    } 
}
