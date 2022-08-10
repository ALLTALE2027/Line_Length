using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Length
{
    internal class LineCompare
    {
        public void lineCompare()
        {
            // ---- UC-3 compare two lines based on the end points, to know one line is equal, greater or less than the other line.  -----
            Console.WriteLine("UC-3 compare two lines based on the end points, to know one line is equal, greater or less than the other line.");
            Console.WriteLine();
            Console.WriteLine("enter the cordinates for first line");
            Console.WriteLine("enter the cordinates for first point");
            (float x1, float y1) = Program.Point();

            Console.WriteLine("enter the cordinates for second point");
            (float x2, float y2) = Program.Point();


            Console.WriteLine("enter the cordinates for second line");
            Console.WriteLine("enter the cordinates for first point");
            (float X1, float Y1) = Program.Point();

            Console.WriteLine("enter the cordinates for second point");
            (float X2, float Y2) = Program.Point();


            //calculate length of line
            double length1 = Program.length(x1, y1, x2, y2);
            double length2 = Program.length(X1, Y1, X2, Y2);


            Console.WriteLine($"Length of the line1 is {length1} and  Length of the line2 is {length2}");

            // check if lengths are equal
            int compare = length1.CompareTo(length2);

            switch (compare)
            {
                case 0:
                    Console.WriteLine("Both lines are equal in length");
                    break;

                case 1:
                    Console.WriteLine("Line 1 is greater in length than line 2");
                    break;

                case -1:
                    Console.WriteLine("line 1 is shorter  in length than Line 2");
                    break;
            }




        }
    }
}
