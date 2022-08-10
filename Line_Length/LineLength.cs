using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Length
{
    internal class LineLength
    {
        public void lineLength()
        {
            // --- UC-1 model a line based on a point consisting of (x, y) co-ordinates using the Cartesian system,calculate its length --- //

            // take two co-ordinate points(x,y) as input from user

            Console.WriteLine("enter the cordinates for first point");
            (float x1, float y1) = Program.Point();

            Console.WriteLine("enter the cordinates for second point");
            (float x2, float y2) = Program.Point();

            //Console.WriteLine(" x1 " + x1+ " " + y1);
            //Console.WriteLine(" x2 " + x2 + " " + y2);

            //calculate length of line
            double length = Program.length(x1, y1, x2, y2);

            Console.WriteLine("Length of the line is : " + Math.Round(length, 3));


        }
    }
}
