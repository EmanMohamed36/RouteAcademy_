namespace Assignment03
{
    internal class Program
    {
        static double CheckDouble(String st)
        {
            double value;
            bool isValid = false;
            do
            {
                Console.Write(st);
                isValid = double.TryParse(Console.ReadLine(), out  value);

            } while (!isValid);
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Coordinates for 2 points: ");
            Console.WriteLine("Point1:");
            double P1X = CheckDouble("X: ");
            double P1Y = CheckDouble("Y: ");
            double P1Z = CheckDouble("Z: ");

            Console.WriteLine("Point2:");
            double P2X = CheckDouble("X: ");
            double P2Y = CheckDouble("Y: ");
            double P2Z = CheckDouble("Z: ");

            Point3D p1 = new Point3D(P1X, P1Y, P1Z);
            Point3D p2 = new Point3D(P2X, P2Y, P2Z);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            if (p1 == p2)
            {
                Console.WriteLine("two points are equal");
            }
            else
            {
                Console.WriteLine("two points are not equal");
            }
        }
    }
}
