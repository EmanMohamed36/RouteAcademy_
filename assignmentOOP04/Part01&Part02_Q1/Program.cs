namespace assignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICircle circle = new Circle(5.0);
            IRectangle rectangle = new Rectangle(4.0, 6.0);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
        }
    }
}
