namespace Line_Length
{
    internal class Program
    {
        public static (float, float) Point()   // (DRY)  method to read co-ordinate points 
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            return (x, y);
        }

        public static double length(float x, float y, float xx, float yy)
        {
            double length = Math.Sqrt(Math.Pow((xx - x), 2) + Math.Pow((yy - y), 2));
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!!!");

            //UC-1
            LineLength Length = new LineLength();
            Length.lineLength();

            //UC-2
            LineEquality equality = new LineEquality();
            equality.lineEquality();


        }
    }
}